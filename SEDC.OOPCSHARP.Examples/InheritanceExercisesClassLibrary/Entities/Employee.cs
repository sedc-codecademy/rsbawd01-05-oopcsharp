using InheritanceExercisesClassLibrary.Enums;

namespace InheritanceExercisesClassLibrary.Entities
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }
        public Role Role { get; set; } 

        public void PrintInfo() 
        {
            Console.WriteLine($"{FirstName} {LastName} - Salary: {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
