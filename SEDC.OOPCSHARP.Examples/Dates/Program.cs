using CSharpClasses.Models;
using System.Globalization;

namespace Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            DateTime tomorrow = new DateTime(2023, 6, 14, 20, 25, 0);

            Console.WriteLine(currentTime);
            Console.WriteLine(tomorrow);

            if (currentTime > tomorrow)
                Console.WriteLine("jest");
            else
                Console.WriteLine("nije");

            DateTime today = DateTime.Today;

            Console.WriteLine(today);

            DateTime empty = new DateTime();
            Console.WriteLine(empty);

            Console.WriteLine(today.ToString("dd/MM/yyyy"));
            Console.WriteLine(today.ToString("dddd, dd MM yyyy"));

            string stringDate = "12-29-2023";
            DateTime dateTimeConverted = DateTime.Parse(stringDate);

            Console.WriteLine("-----------------");

            DateTime added7Days = currentTime.AddDays(7);
            DateTime added20Days = currentTime.AddDays(20);
            DateTime removed10Days = currentTime.AddDays(-10);

            DateTime added10Months = currentTime.AddMonths(10);
            DateTime added5Years= currentTime.AddYears(5);
            DateTime added5Hours = currentTime.AddHours(5);


            Console.WriteLine(added7Days.ToString("dddd, dd MM yyyy"));
            Console.WriteLine(added20Days.ToString("dddd, dd MM yyyy"));
            Console.WriteLine(removed10Days.ToString("dddd, dd MM yyyy"));
            Console.WriteLine(added10Months.ToString("dddd, dd MM yyyy"));
            Console.WriteLine(added5Years.ToString("dddd, dd MM yyyy"));
            Console.WriteLine(added5Hours.ToString("dddd, dd MM yyyy"));

            int day = currentTime.Day;
            int month = currentTime.Month;
            int year = currentTime.Year;

            Console.WriteLine(day);
            Console.WriteLine(month);
            Console.WriteLine(year);

            #region Exercise 4
            DateTime todayX = DateTime.Today;
            Console.WriteLine(today.AddDays(3));
            Console.WriteLine(today.AddMonths(1).AddDays(3));
            Console.WriteLine(today.AddYears(-1).AddMonths(-2));
            Console.WriteLine(string.Format("{0:MMMM}", today));
            Console.WriteLine(string.Format("{0:yyyy}", today));
            #endregion
        }
    }
}