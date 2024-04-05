
namespace ScooterRental.Exceptions
{
    public class ScooterNotFoundException : Exception
    {
        public ScooterNotFoundException() : base("No scooters found")
        {
        }

        public ScooterNotFoundException(string v) : base("No scooters found")
        {
        }

        
    }
}
