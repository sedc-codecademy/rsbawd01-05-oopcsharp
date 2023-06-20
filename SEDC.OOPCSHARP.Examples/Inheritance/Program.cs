using Inheritance.Models;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() 
            { 
                FirstName = "Student 1 F",
                LastName = "Student 1 L",
                Id = 1,
                IdentificationNumber = "ZZZZ1111ZZZ"
            };

            Professor professor = new Professor()
            {
                Id = 2,
                FirstName = "Professor 1 F",
                LastName = "Professor 1 L",
                Courses = new[] { "Math", "Programming", "Chemistry"}
            };

            Assistent assistent = new Assistent()
            {
                Id = 3,
                FirstName = "Assistent 1 F",
                LastName = "Assistent 1 L",
                Materials = new[] { "math01.pdf", "math02.pdf", "math03.pdf" }
            };

            student.PrintInfo();
            professor.PrintInfo();
            assistent.PrintInfo();
        }
    }
}