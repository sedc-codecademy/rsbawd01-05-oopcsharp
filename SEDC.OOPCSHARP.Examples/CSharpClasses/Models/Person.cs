using System.Globalization;

namespace CSharpClasses.Models
{
    public class Person
    {
        private int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName   { get; set; }
        public int Age { get; set; }

        public Person() 
        {
            Id = GenerateId();
        }

        public Person(string firstName, string lastName, int age) 
        { 
            FirstName = firstName;
            LastName = lastName;
            Age = age; 
            Id = GenerateId();
        }

        public void IntroduceYourSelf() 
        {
            Console.WriteLine($"Hi, I am {FirstName} {LastName}, I am {Age} years old, my ID is:{Id}");
        }

        private int GenerateId() 
        {
            return new Random().Next(1, 1000);
        }
    }
}
