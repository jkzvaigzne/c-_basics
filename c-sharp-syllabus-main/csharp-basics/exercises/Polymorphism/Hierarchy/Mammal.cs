namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }

        public Mammal(string name, string type, double weight, string livingRegion)
            : base(name, type, weight) => LivingRegion = livingRegion;

        public override string ToString() => $"{base.ToString()}, {LivingRegion}";
    }
}
