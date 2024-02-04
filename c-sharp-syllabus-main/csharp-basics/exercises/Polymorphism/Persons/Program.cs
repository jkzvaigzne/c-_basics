using System;

namespace Persons
{
    class Program
    {
        private const int MinRandomId = 1;
        private const int MaxRandomId = 10;

        static void Main(string[] args)
        {
            Random random = new Random();

            int johnDoeId = random.Next(MinRandomId, MaxRandomId + 1);
            int janeDoeId = random.Next(MinRandomId, MaxRandomId + 1);

            var johnDoe = new StudentModels.Student("John", "Doe", "Riga", johnDoeId, 99);
            var janeDoe = new StudentModels.Student("Jane", "Doe", "Riga", janeDoeId, 98);

            int johnDoeEmployeeId = random.Next(MinRandomId, MaxRandomId + 1);
            int janeDoeEmployeeId = random.Next(MinRandomId, MaxRandomId + 1);

            var johnDoeAsEmployee = new EmployeeModels.Employee("John", "Doe Employee", "Cesis", johnDoeEmployeeId, "Backend developer");
            var janeDoeAsEmployee = new EmployeeModels.Employee("Jane", "Doe Employee", "Cesis", janeDoeEmployeeId, "Front-end developer");

            DisplayFormattedOutput("Students:", johnDoe, janeDoe);
            DisplayFormattedOutput("Employees:", johnDoeAsEmployee, janeDoeAsEmployee);

            Console.Read();
        }

        static void DisplayFormattedOutput(string employmentStatus, params Models.Person[] people)
        {
            Console.WriteLine(employmentStatus);
            foreach (var person in people)
            {
                person.Output();
                Console.WriteLine();
            }
        }
    }
}
