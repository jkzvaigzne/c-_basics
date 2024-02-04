using System;

namespace Persons.Models
{
    internal class Person
    {
        public string FirstName { get; set; } = "No FirstName";
        public string LastName { get; set; } = "No LastName";
        public string Address { get; set; } = "No Adress";
        public int? Id { get; set; } = null;

        public Person() { }

        public Person(string firstName, string lastName, string address, int id)
            => (FirstName, LastName, Address, Id) = (firstName, lastName, address, id);

        public virtual void Output()
            => Console.WriteLine($"First Name: {FirstName}\nLast Name: {LastName}\nAddress: {Address}\nID: {Id}");
    }
}
