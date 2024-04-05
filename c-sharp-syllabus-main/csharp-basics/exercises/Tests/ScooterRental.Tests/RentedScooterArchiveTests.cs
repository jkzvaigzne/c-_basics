using FluentAssertions;
using ScooterRental.Exceptions;


namespace ScooterRental.Tests
{
    [TestClass]
    public class RentedScooterArchiveTests
    {
        private List<RentedScooter> _rentedScooters;
        private RentedScooterArchive _archive;

        [TestInitialize]
        public void TestInitialize()
        {
            _rentedScooters = new List<RentedScooter>
            {
                new RentedScooter("1", new DateTime(2023, 01, 23, 10, 00, 00), 0.2m),
                new RentedScooter("2", new DateTime(2023, 02, 20, 12, 00, 00), 0.1m),
                new RentedScooter("3", new DateTime(2023, 03, 13, 14, 00, 00), 0.3m),
            };

            _archive = new RentedScooterArchive(_rentedScooters);
        }

        [TestMethod]
        public void AddRentedScooter_Adds_Rented_Scooter_To_List()
        {
            //Act
            _archive.AddRentedScooter(new RentedScooter("1", new DateTime(2023, 04, 13, 14, 00, 00), 0.3m));
            _archive.AddRentedScooter(new RentedScooter("1", new DateTime(2023, 04, 14, 14, 00, 00), 0.3m));

            //Assert
            _rentedScooters.Count.Should().Be(5);
        }

        [TestMethod]
        public void EndRental_Provided_ExistingId_And_Valid_Date_Should_Update_EndTime()
        {
            //Act
            _archive.EndRental("1", new DateTime(2023, 01, 25, 10, 00, 00));

            //Assert
            _rentedScooters.LastOrDefault(scooter => scooter.ScooterId == "1").RentEnd.Should().Be(new DateTime(2023, 01, 25, 10, 00, 00));
        }
       
        [TestMethod]
        public void GetAllRentedScooterList_Should_Return_Correct_List()
        {
            //Act
            var scooterList = _archive.GetAllRentedScooterList();

            //Assert
            _rentedScooters.Should().BeEquivalentTo(scooterList);
        }
    }
}
