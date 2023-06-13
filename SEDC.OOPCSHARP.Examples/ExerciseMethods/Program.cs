namespace ExerciseMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExerciseOne();
        }

        public static void ExerciseOne() 
        {
            Console.Write("Enter an operation ( + or - ):");

            string operation = Console.ReadLine();

            if (operation != "+" && operation != "-")
            {
                Console.WriteLine("Sorry! Wrong input!");
                return;
            }

            Console.Write("Enter first number:");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number:");
            int number2 = int.Parse(Console.ReadLine());

            if (operation == "+")
                Console.WriteLine(Sum(number1, number2));

            if (operation == "-")
                Console.WriteLine(Subtract(number1, number2));
        }

        public static int Sum(int num1, int num2)
        { 
            int result = num1 + num2;
            return result;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}