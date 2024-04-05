namespace ScooterRental.Exceptions
{
    public class InvalidEmptyIDException : Exception
    {
        public InvalidEmptyIDException() : base("scooter id can not be empty or null")
        {

        }
    }
}
