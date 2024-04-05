namespace ScooterRental
{
    public interface IRentalCalculatorService
    {
        decimal CalculateIncome(int? year, bool includeNotCompletedRentals);
        decimal CalculateIncome(object value, bool v);
        decimal CalculateRent(RentedScooter rentalRecord);
        decimal CalculateRentalCost(int rentalDurationInMinutes, decimal pricePerMinute);
    }
}
