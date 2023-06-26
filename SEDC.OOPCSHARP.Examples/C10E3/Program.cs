using C10E3.Models;

namespace C10E3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Rectangle Area Calculator\n");

            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Enter the length: ");
            rectangle.Length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width: ");
            rectangle.Width = int.Parse(Console.ReadLine());

            // Calculate the area
            int area = rectangle.CalculateArea();

            // Display the area on the console
            Console.WriteLine($"\nArea: {area}");

            Console.ReadLine();
        }
    }    
}