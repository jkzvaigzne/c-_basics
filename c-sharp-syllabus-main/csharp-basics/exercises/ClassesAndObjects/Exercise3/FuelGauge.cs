namespace Exercise3
{
    public class FuelGauge
    {
        private const int MaxLiters = 70;
        public int Liters { get; private set; }

        public FuelGauge(int liters)
        {
            Liters = (liters > MaxLiters) ? MaxLiters : liters;
        }

        public int GetFuelAmount() => Liters;

        public void AddFuel()
        {
            if (Liters < MaxLiters)
            {
                Liters++;
            }
        }

        public void RemoveFuel()
        {
            if (Liters > 0)
            {
                Liters--;
            }
        }
    }
}
