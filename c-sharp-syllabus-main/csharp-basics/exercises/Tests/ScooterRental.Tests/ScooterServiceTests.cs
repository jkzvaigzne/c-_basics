using FluentAssertions;
using ScooterRental.Exceptions;

namespace ScooterRental.Tests;

[TestClass]
public class ScooterServiceTests
{
    private ScooterService _scooterService;
    private List<Scooter> _scooters;
    private const string _defaultScooterID = "1";
    private const decimal DefaultPricePerMinute = 0.5m;


    [TestInitialize]
    public void Setup()
    {
        _scooters = new List<Scooter>();
        _scooterService = new ScooterService(_scooters);
    }

    [TestMethod]
    public void AddScooter_Valid_Data_Provided_ScooterAdded()
    {

        // Act 
        _scooterService.AddScooter(_defaultScooterID, 0.1m);


        // Assert
        _scooters.Count().Should().Be(1);
    }

    [TestMethod]
    public void AddScooter_Invalid_Price_Provided_InvalidPriceException_Expected()
    {

        // Act 
        Action action = () => _scooterService.AddScooter(_defaultScooterID, 0.0m);

        // Assert
        action.Should().Throw<InvalidPriceException>();
    }

    [TestMethod]
    public void AddScooter_Invalid_Id_Provided_InvalidIdException_Expected()
    {

        // Act 
        Action action = () => _scooterService.AddScooter("", 0.1m);

        // Assert
        action.Should().Throw<InvalidIdException>();
    }

    [TestMethod]
    public void AddScooter_AddDuplicate_Scooter_DuplicateScooterException_Expected()
    {
        // Arrange 
        _scooters.Add(new Scooter(_defaultScooterID, 0.5m));


        // Act 
        Action action = () => _scooterService.AddScooter(_defaultScooterID, 0.1m);

        // Assert
        action.Should().Throw<DuplicateScooterException>();
    }

    [TestMethod]
    public void RemoveScooter_Existing_ScooterId_Provided_Scooter_Removed()
    {
        // Arrange 
        _scooters.Add(new Scooter(_defaultScooterID, 0.5m));


        // Act
        _scooterService.RemoveScooter(_defaultScooterID);

        // Assert
        _scooters.Count.Should().Be(0);
    }

    [TestMethod]
    public void RemoveScooter_NonExisting_ScooterId_Provided_ScooterNotFoundException_Expected()
    {

        // Act
        Action action = () => _scooterService.RemoveScooter(_defaultScooterID);

        // Assert
        action.Should().Throw<ScooterNotFoundException>();
    }

    [TestMethod]
    public void GetScooterById_NonExisting_ScooterId_Provided_ScooterIdNotFoundException_Expected()
    {
        // Arrange
        _scooterService = new ScooterService(new List<Scooter>());

        // Act
        Action action = () => _scooterService.GetScooterById(_defaultScooterID);

        // Assert
        action.Should().Throw<ScooterIdNotFoundException>();
    }

    [TestMethod]
    public void GetScooterById_EmptyId_InvalidEmptyIDException()
    {
        // Act
        Action action = () => _scooterService.GetScooterById("");


        // Assert
        action.Should().Throw<InvalidEmptyIDException>();
    }

    [TestMethod]
    public void GetScooters_EmptyList_NotCountScooterException_Expected()
    {
        // Arrange
        _scooterService = new ScooterService(new List<Scooter>());

        // Act
        Action action = () => _scooterService.GetScooters();

        // Assert
        action.Should().Throw<NotCountScooterException>();
    }

    [TestMethod]
    public void RemoveScooter_ScooterExists_ScooterIsRemoved()
    {
        // Arrange
        _scooters.Add(new Scooter("1", 0.2m));

        // Act
        Action action = () => _scooterService.RemoveScooter("1");

        // Assert
        action.Should().NotThrow();
        _scooters.Count.Should().Be(0);
    }

}
