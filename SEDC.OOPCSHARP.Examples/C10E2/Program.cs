namespace C10E2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Simple Calculator\n");

            // Get the first number from the user
            Console.WriteLine("Enter the first number: ");
            double num1 = int.Parse(Console.ReadLine());

            // Get the operator from the user
            Console.WriteLine("Enter the operator (+, -, *, /): ");
            string oper = Console.ReadLine();

            // Get the second number from the user
            Console.WriteLine("Enter the second number: ");
            double num2 = int.Parse(Console.ReadLine());

            double result = 0;

            // Perform the arithmetic operation based on the operator
            switch (oper)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    return;
            }

            // Display the result
            Console.WriteLine(".....................");
            Console.WriteLine($"Result: {result}");
            Console.WriteLine(".....................");
        }
    }
}