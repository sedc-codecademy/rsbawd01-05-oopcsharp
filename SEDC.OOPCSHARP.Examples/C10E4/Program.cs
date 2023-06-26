using C10E4.Models;

namespace C10E4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Person List\n");

            // Create a list of Person objects and populate it
            List<Person> persons = new List<Person>()
            {
                new Person { Name = "John", Age = 25, Gender = "Male" },
                new Person { Name = "Alice", Age = 35, Gender = "Female" },
                new Person { Name = "Michael", Age = 42, Gender = "Male" },
                new Person { Name = "Emily", Age = 28, Gender = "Female" },
                new Person { Name = "Robert", Age = 50, Gender = "Male" }
            };

            // Use LINQ to filter the list and select persons older than 30
            var filteredList = persons.Where(p => p.Age > 30);

            // Order the filtered list by age in descending order
            var orderedList = filteredList.OrderByDescending(p => p.Age);

            // Display the name and age of each person in the console
            foreach (var person in orderedList)
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}