namespace FuelConsumptionCalculator
{
    public class Car
    {
        public double StartKilometers { get; private set; }
        public double EndKilometers { get; private set; }
        public double Liters { get; private set; }

        public Car(double startOdo, double endingOdo, double liters)
        {
            StartKilometers = startOdo;
            EndKilometers = endingOdo;
            Liters = liters;
        }

        public Car(double startOdo)
        {
            StartKilometers = startOdo;
        }

        public void FillUp(int mileage, double liters)
        {
            StartKilometers = EndKilometers;
            EndKilometers = mileage;
            Liters = liters;
        }

        public double CalculateConsumptions() => Liters * 100 / (EndKilometers - StartKilometers);

        public bool IsGasHog() => CalculateConsumptions() > 15.0;

        public bool IsEconomyCar() => CalculateConsumptions() < 5.0;
    }

}
