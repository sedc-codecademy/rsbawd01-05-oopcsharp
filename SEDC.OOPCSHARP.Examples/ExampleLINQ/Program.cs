using ExampleLINQ.Models;

namespace ExampleLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Person 
            { 
                Id = 1,
                Age = 28,
                FirstName = "Almir",
                LastName = "Vuk"
            });

            people.Add(new Person 
            { 
                Id = 2, 
                Age = 35, 
                FirstName = "Zoran",
                LastName = "Malinovic"
            });

            people.Add(new Person
            {
                Id = 3,
                Age = 35,
                FirstName = "Miroslav",
                LastName = "Popovic"
            });

            people.Add(new Person
            {
                Id = 4,
                Age = 55,
                FirstName = "Bill",
                LastName = "Gates"
            });

            PrintList(people);

            // Get me items with Age == 35
            List<Person> peopleWithAge35 = people.Where(p => p.Age == 35 && p.LastName.StartsWith("P"))
                                                 .ToList();

            Console.WriteLine("With age 35");
            PrintList(peopleWithAge35);

            // Get me element with Id = 2
            Person personId2 = people.Where(p => p.Id == 2)
                                     .First();

            string namePersonWithAge28 = people.Where(p => p.Age == 28)
                                               .Select(p => p.FirstName)
                                               .First();

            List<Person> orderedByAgeDESC = people.OrderByDescending(p => p.Age)
                                                  .ToList();

            Console.WriteLine("After ordering by Age - DESCENDING");
            Console.WriteLine("...................................");

            PrintList(orderedByAgeDESC);
        }

        static void PrintList(List<Person> list) 
        {
            foreach (Person person in list)
            {
                Console.WriteLine($"Id: {person.Id}");
                Console.WriteLine($"First name: {person.FirstName}");
                Console.WriteLine($"Last name: {person.LastName}");
                Console.WriteLine($"Age: {person.Age}");
                Console.WriteLine("............................");
            }
        }

    }
}