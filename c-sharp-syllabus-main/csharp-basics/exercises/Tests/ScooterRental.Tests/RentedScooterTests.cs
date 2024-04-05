using FluentAssertions;
using ScooterRental.Exceptions;



namespace ScooterRental.Tests
{
    [TestClass]
    public class RentedScooterTests
    {
        private readonly string _id = "1";
        private readonly DateTime _startDate = new DateTime(2024, 01, 01, 00, 00, 00);
        private decimal _pricePerMinute = 0.2m;

        [TestMethod]
        public void Constructor_Should_Set_ScooterId_RentStart_PricePerMinute_Correctly()
        {
            // Arrange
            var rentedScooter = new RentedScooter(_id, _startDate, _pricePerMinute);

            // Assert
            rentedScooter.ScooterId.Should().Be(_id);
            rentedScooter.RentStart.Should().Be(_startDate);
            rentedScooter.PricePerMinute.Should().Be(_pricePerMinute);
        }

        [TestMethod]
        public void Property_RentEnd_Should_Set_RentEnd_Correctly()
        {
            // Arrange
            DateTime rentEnd = new DateTime(2024, 01, 02, 10, 00, 00);
            var rentedScooter = new RentedScooter(scooterId: _id, rentStart: _startDate, pricePerMinute: _pricePerMinute);

            // Act
            rentedScooter.RentEnd = rentEnd;

            // Assert
            rentedScooter.RentEnd.Should().Be(rentEnd);
        }

        [TestMethod]
        public void RentEnd_Setting_Null_Should_Set_RentEnd_To_Null()
        {
            // Arrange
            DateTime rentEnd = new DateTime(2024, 01, 02, 10, 00, 00);
            var rentedScooter = new RentedScooter(scooterId: _id, rentStart: _startDate, pricePerMinute: _pricePerMinute);
            rentedScooter.RentEnd = rentEnd;

            // Act
            rentedScooter.RentEnd = null;

            // Assert
            rentedScooter.RentEnd.Should().BeNull();
        }
    }
}
