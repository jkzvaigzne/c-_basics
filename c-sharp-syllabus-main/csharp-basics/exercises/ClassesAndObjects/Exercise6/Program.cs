namespace Exercise6
{
    internal class DogTest
    {
        static void Main(string[] args)
        {
            var Sparky = new Dog("Sparky", "male");
            var Sam = new Dog("Sam", "male");
            var Lady = new Dog("Lady", "female");
            var Molly = new Dog("Molly", "female");
            var Buster = new Dog("Buster", "male", Lady, Sparky);
            var Rocky = new Dog("Rocky", "male", Molly, Sam);
            var Max = new Dog("Max", "male", Lady, Rocky);
            var Coco = new Dog("Coco", "female", Molly, Buster);

            Console.WriteLine(Coco.DogFatherName());
            Console.WriteLine(Sparky.DogFatherName());
            Console.WriteLine(Coco.HasDogMother(Rocky));

            Console.Read();
        }
    }
}
