namespace ScooterRental.Exceptions
{
    public class NotCountScooterException : Exception
    {
        public NotCountScooterException() : base("No scooters available")
        {

        }
    }
}
