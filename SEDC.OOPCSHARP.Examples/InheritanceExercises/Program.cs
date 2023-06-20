using InheritanceExercisesClassLibrary.Entities;
using InheritanceExercisesClassLibrary.Enums;

namespace InheritanceExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { FirstName = "Bob" , LastName = "Bobsky", Role = Role.Other };
            SalesPerson sale = new SalesPerson("Bill", "Billsky", 1500);
            Manager manager = new Manager("Elon", "Musk", 5000);

            sale.ExtendSuccessSaleRevenue(2000);

            manager.AddBonus(2000);

            emp.PrintInfo();
            sale.PrintInfo();
            manager.PrintInfo();

            Console.WriteLine("Employee Salary: " + emp.GetSalary());
            Console.WriteLine("Sales Person Salary: " + sale.GetSalary());
            Console.WriteLine("Manager Person Salary: " + manager.GetSalary());

            Console.ReadLine();
        }
    }
}