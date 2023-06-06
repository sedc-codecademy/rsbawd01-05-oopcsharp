namespace TreesExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 5 - 7
            // Exercise 5
            Console.Write("Please enter number of trees: ");
            int trees = int.Parse(Console.ReadLine());
            int n = 8;
            int m = 5;
            int treeApples = n * 12 * trees;
            int result;

            if (treeApples % m == 0)
            {
                result = treeApples / m;
            }
            else
            {
                result = treeApples / m + 1;
            }
            Console.WriteLine("You would need :" + result + " baskets!");

            // Exercise 6
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = int.Parse(Console.ReadLine());
            int larger;
            if (num1 > num2)
            {
                larger = num1;
                Console.WriteLine("First is larger!");
            }
            else if (num2 > num1)
            {
                larger = num2;
                Console.WriteLine("Second is larger!");
            }
            else
            {
                larger = num1;
                Console.WriteLine("The numbers are equal!");
            }

            if (larger != 0)
            {
                if (larger % 2 == 0)
                {
                    Console.WriteLine("Number is Even!");
                }
                else if (larger % 2 != 0)
                {
                    Console.WriteLine("Number is Odd!");
                }
            }
            else
            {
                Console.WriteLine("You entered Zero. That is not even nore odd!");
            }

            // Exercise 7
            Console.WriteLine("Whats behind door 1,2,3");
            int door;
            bool isNumber = int.TryParse(Console.ReadLine(), out door);
            if (isNumber)
            {
                switch (door)
                {
                    case 1:
                        Console.WriteLine("You got a new car");
                        break;
                    case 2:
                        Console.WriteLine("You got a new plane");
                        break;
                    case 3:
                        Console.WriteLine("You got a new house");
                        break;
                    default:
                        Console.WriteLine("That was not 1 2 or 3! Sorry!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("That was not a number! Sorry!");
            }
            #endregion

        }
    }
}