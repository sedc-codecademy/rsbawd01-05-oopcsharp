using InheritanceExercisesClassLibrary.Enums;

namespace InheritanceExercisesClassLibrary.Entities
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager(string first, string last, double salary)
        {
            FirstName = first;
            LastName = last;
            Bonus = 0;
            Salary = salary;
            Role = Role.Manager;
        }

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
