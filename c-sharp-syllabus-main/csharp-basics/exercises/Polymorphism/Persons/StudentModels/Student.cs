using System;

namespace Persons.StudentModels
{
    internal class Student : Models.Person
    {
        private double GPA { get; }

        public Student(string firstName, string lastName, string address, int id, double gpa)
            : base(firstName, lastName, address, id) => GPA = gpa;

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"GPA: {GPA}");
        }
    }
}
