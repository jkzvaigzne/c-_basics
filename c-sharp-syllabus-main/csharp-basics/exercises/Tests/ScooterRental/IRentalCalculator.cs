namespace ScooterRental
{
    public interface IRentalCalculator
    {
        decimal CalculateRent(RentedScooter rentalRecord);

        decimal CalculateIncome(int? year, bool includeNotCompletedRentals);
    }
}