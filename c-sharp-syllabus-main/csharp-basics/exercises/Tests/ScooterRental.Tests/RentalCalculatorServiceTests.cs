using FluentAssertions;
using Moq;
using Moq.AutoMock;
using ScooterRental.Exceptions;

namespace ScooterRental.Tests
{
    [TestClass]
    public class RentalCalculatorServiceTests
    {
        private AutoMocker _mocker;
        private Mock<IRentedScooterArchive> _rentedScooterArchiveMock;
        private IRentalCalculatorService _rentalCalculator;
        private readonly Scooter _scooter = new Scooter("1", 0.2m) { IsRented = true };

        private readonly List<RentedScooter> _rentedScooterList = new List<RentedScooter>
        {
            new RentedScooter("1", DateTime.Now.AddMinutes(-90), 0.2m) { RentEnd = DateTime.Now },
            new RentedScooter("2", new DateTime(2023, 1, 15, 8, 0, 0), 0.2m) { RentEnd = new DateTime(2023, 1, 15, 8, 30, 0) },
            new RentedScooter("3", DateTime.Now.AddMinutes(-30), 0.2m),
            new RentedScooter("4", new DateTime(2024, 3, 10, 14, 0, 0), 0.2m) { RentEnd = new DateTime(2024, 3, 11, 14, 0, 0) },
        };

        [TestInitialize]
        public void Initialize()
        {
            _mocker = new AutoMocker();
            _rentedScooterArchiveMock = _mocker.GetMock<IRentedScooterArchive>();
            _rentedScooterArchiveMock.Setup(archive => archive.GetAllRentedScooterList()).Returns(_rentedScooterList);
            _rentalCalculator = new RentalCalculatorService(_rentedScooterArchiveMock.Object);
        }

        [TestMethod]
        public void CalculateRent_Should_Calculate_Rent_Correctly()
        {
            AssertRent(19.8m, DateTime.Now.AddMinutes(-99), DateTime.Now);
            AssertRent(20m, new DateTime(2024, 1, 26, 8, 0, 0), new DateTime(2024, 1, 26, 8, 0, 0).AddMinutes(121));
            AssertRent(24.2m, new DateTime(2024, 1, 26, 23, 10, 0), new DateTime(2024, 1, 26, 23, 10, 0).AddMinutes(121));
            AssertRent(72m, new DateTime(2024, 1, 26, 23, 10, 0), new DateTime(2024, 1, 30, 0, 10, 0));
            AssertRent(3.8m, DateTime.Now.AddMinutes(-19), null);
        }

        [TestMethod]
        public void CalculateIncome_Should_Calculate_Income_Correctly()
        {
            var rentalCalculator = GetRentalCalculator();

            AssertIncome(rentalCalculator, 70m, null, true);
            AssertIncome(rentalCalculator, 6m, 2023, true);
            AssertIncome(rentalCalculator, 58m, 2024, false);
            AssertIncome(rentalCalculator, 64m, 2024, true);
            AssertIncome(rentalCalculator, 64m, null, false);

            Action action = () => rentalCalculator.CalculateIncome(DateTime.Now.AddYears(1).Year, true);
            action.Should().Throw<InvalidYearException>();
        }

        private void AssertRent(decimal expectedRent, DateTime startRentTime, DateTime? endRentTime)
        {
            var rentalRecord = new RentedScooter(_scooter.Id, startRentTime, _scooter.PricePerMinute) { RentEnd = endRentTime };
            _rentalCalculator.CalculateRent(rentalRecord).Should().Be(expectedRent);
        }

        private IRentalCalculatorService GetRentalCalculator()
        {
            return _rentalCalculator;
        }

        private void AssertIncome(IRentalCalculatorService rentalCalculator, decimal expectedIncome, int? year, bool includeNotCompletedRentals)
        {
            rentalCalculator.CalculateIncome(year, includeNotCompletedRentals).Should().Be(expectedIncome);
        }
    }
}
