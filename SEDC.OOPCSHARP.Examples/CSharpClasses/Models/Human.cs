using MyUsefulLibrary.Enums;

namespace CSharpClasses.Models
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Gender Gender { get; set; }

        public string GetPersonStats()
        {
            return $"Name: {FirstName} {LastName}, Age:{Age}";
        }
    }
}
