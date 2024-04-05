using FluentAssertions;

namespace ScooterRental.Tests
{
    [TestClass]
    public class ScooterTests
    {
        private Scooter _scooter;

        [TestMethod]
        public void ScooterCreation_IDAndPricePerMinuteSetCorrectly()
        {
            // Arrange
            _scooter = new Scooter("2", 0.1m);

            // Act and Assert
            _scooter.Id.Should().Be("2");
            _scooter.PricePerMinute.Should().Be(0.1m);

            _scooter.IsRented.Should().BeFalse();
        }

        [TestMethod]
        public void Property_IsRented_Sets_Correctly()
        {
            //Arrange
            _scooter = new Scooter("1", 0.2m);

            //Act
            _scooter.IsRented = true;

            //Assert
            _scooter.IsRented.Should().BeTrue();
        }
    }
}
