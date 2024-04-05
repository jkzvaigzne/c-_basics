namespace ScooterRental.Exceptions
{
    public class CannotRemoveRentedScooterException : Exception
    {
        public CannotRemoveRentedScooterException() : base("scooter id can not be empty or null")
        {

        }
    }
}
