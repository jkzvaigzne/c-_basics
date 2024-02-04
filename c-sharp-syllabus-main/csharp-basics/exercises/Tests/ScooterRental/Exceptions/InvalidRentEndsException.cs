namespace ScooterRental.Exceptions
{
    public class InvalidRentEndsException : Exception
    {
        public InvalidRentEndsException() : base("RentEnd cannot be before RentStart") { }
    }
}
