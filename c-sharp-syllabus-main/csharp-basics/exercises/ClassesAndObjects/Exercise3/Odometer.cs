namespace Exercise3
{
    public class Odometer
    {
        private const int MaxMileage = 999999;
        private const int FuelEconomy = 10;

        public int Mileage { get; private set; }

        private FuelGauge fuelGauge;

        public Odometer(int mileage, FuelGauge fuelGauge)
        {
            Mileage = (mileage > MaxMileage) ? MaxMileage : mileage;
            this.fuelGauge = fuelGauge;
        }

        public int GetMileage()
        {
            return Mileage;
        }

        public void IncrementMileage()
        {
            if (Mileage == MaxMileage)
            {
                Mileage = 0;
            }
            else
            {
                Mileage++;

                if (Mileage % FuelEconomy == 0)
                {
                    fuelGauge.RemoveFuel();
                }
            }
        }
    }
}
