namespace ScooterRental.Exceptions
{
    public class ScooterIdNotFoundException : Exception
    {
        public ScooterIdNotFoundException() : base("Scooter id not found")
        {

        }
    }
}
