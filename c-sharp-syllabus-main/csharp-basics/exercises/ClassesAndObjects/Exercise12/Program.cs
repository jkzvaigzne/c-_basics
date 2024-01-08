using System;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestPaper paperFirst = new TestPaper("Maths", new[] { "1A", "2C", "3D", "4A", "5A" }, "60%");
            ITestPaper paperSecond = new TestPaper("Chemistry", new[] { "1C", "2C", "3D", "4A" }, "75%");
            ITestPaper paperThird = new TestPaper("Computing", new[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");

            IStudent firstStudent = new Student();
            IStudent secondStudent = new Student();

            firstStudent.TakeTest(paperFirst, new[] { "1A", "2D", "3D", "4A", "5A" });
            secondStudent.TakeTest(paperSecond, new[] { "1C", "2D", "3A", "4C" });
            secondStudent.TakeTest(paperThird, new[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B" });

            DisplayResults($"First student:", firstStudent.TestsTaken);
            DisplayResults($"Second student:", secondStudent.TestsTaken);

            Console.Read(); 
        }

        static void DisplayResults(string studentName, string[] results)
        {
            Console.WriteLine($"{studentName} Result");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine("-");
        }
    }
}
