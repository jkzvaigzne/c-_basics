using ScooterRental.Exceptions;

namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {
        private readonly IScooterService _scooterService;
        private readonly IRentedScooterArchive _archive;
        private readonly IRentalCalculator _calculator;

        public RentalCompany(
            string name,
            IScooterService scooterService,
            IRentedScooterArchive archive,
            IRentalCalculator calculator)
        {
            Name = name;
            _scooterService = scooterService;
            _archive = archive;
            _calculator = calculator;
        }

        public string Name {  get; }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            return _calculator.CalculateIncome(year, includeNotCompletedRentals);
        }

        public decimal EndRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);
            var rentalRecord = _archive.EndRental(scooter.Id, DateTime.Now);
            scooter.IsRented = false;

            return _calculator.CalculateRent(rentalRecord);
        }

        public void StartRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);
            _archive.AddRentedScooter(new RentedScooter(scooter.Id, DateTime.Now, scooter.PricePerMinute));
            scooter.IsRented = true;
        }


    }
}
