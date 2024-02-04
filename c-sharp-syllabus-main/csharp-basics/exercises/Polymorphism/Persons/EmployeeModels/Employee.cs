using System;

namespace Persons.EmployeeModels
{
    internal class Employee : Models.Person

    {
        private string JobTitle { get; }

        public Employee(string firstName, string lastName, string address, int id, string jobTitle)
            : base(firstName, lastName, address, id) => JobTitle = jobTitle;

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Job Title: {JobTitle}");
        }
    }
}
