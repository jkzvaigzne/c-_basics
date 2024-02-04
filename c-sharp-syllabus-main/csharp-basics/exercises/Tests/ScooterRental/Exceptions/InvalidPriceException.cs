namespace ScooterRental.Exceptions
{
    public class InvalidPriceException : Exception
    {
        public InvalidPriceException() : base("price per minute is not valid")
        {

        }
    }
}
