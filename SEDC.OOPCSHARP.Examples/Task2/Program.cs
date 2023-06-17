namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool next = true;

            do 
            {
                Console.Write("Enter a number:");

                double number;
                bool isNumber = double.TryParse(Console.ReadLine(), out number);
                
                if (!isNumber)
                {
                    Console.WriteLine("That was not a number! Please try again!");
                    continue;
                }
                
                NumberStats(number);

                Console.Write("Press any key to try again or X to exit.");
                
                if (Console.ReadLine().ToUpper() == "X")
                    next = false;

            } while (next);
        }

        public static void NumberStats(double number)
        {
            bool isNegative;
            bool isDecimal;
            bool isEven;

            if (number < 0)
                isNegative = true;
            else
                isNegative = false;

            if (number % 1 > 0)
                isDecimal = true;
            else
                isDecimal = false;

            if (number % 2 == 0)
                isEven = true;
            else
                isEven = false;

            Console.WriteLine($"Stats for number: {number}");
            
            Console.WriteLine(string.Format("{0}", isNegative ? "Negative" : "Positive"));
            Console.WriteLine(string.Format("{0}", isDecimal ? "Decimal" : "Integer"));
            Console.WriteLine(string.Format("{0}", isEven ? "Even" : "Odd"));
        }
    }
}