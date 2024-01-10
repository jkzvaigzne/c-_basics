namespace Exercise6
{
    public class Dog
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public Dog Mother { get; set; }
        public Dog Father { get; set; }

        public Dog(string name, string sex, Dog mother = null, Dog father = null)
        {
            Name = name;
            Sex = sex;
            Mother = mother;
            Father = father;
        }

        public string DogFatherName() => Father?.Name ?? "Unknown";

        public bool HasDogMother(Dog anotherDog) =>
            Mother?.Name == anotherDog.Mother?.Name && !string.IsNullOrEmpty(Mother?.Name);
    }
}
