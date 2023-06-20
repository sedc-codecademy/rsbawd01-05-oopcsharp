using MyUsefulLibrary.Enums;

namespace Inheritance.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        protected string SomeProtectedValue { get; set; }
        
        public Gender Gender { get; set; }

        public virtual void PrintInfo() 
        {
            Console.WriteLine($"Hi, my name is {FirstName} {LastName}");
        }
    }
}
