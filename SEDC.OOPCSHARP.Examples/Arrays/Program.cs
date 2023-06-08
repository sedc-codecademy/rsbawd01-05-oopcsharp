using System.Xml.Linq;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            numbers[0] = 10;
            numbers[1] = 15;
            numbers[2] = 12;
            numbers[3] = 7;
            numbers[4] = 6;

            Console.WriteLine("Elements of numbers array: ");

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);

            Console.WriteLine("for loop ----------------");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Other ways of defining array in C#
            int[] numberArrayB = new int[] { 10, 10, 10, 11, 20, 2, 1 };

            int[] numbersArrayC = { 1, 2, 3, 4, 5, 10, 20, 30 };

            for (int i = 0; i < numberArrayB.Length; i++)
                Console.WriteLine(numberArrayB[i]);

            for (int i = 0; i < numbersArrayC.Length; i++)
                Console.WriteLine(numbersArrayC[i]);

            int indexFound = Array.IndexOf(numberArrayB, 11);
            Console.WriteLine("Value 11 is located at: " + indexFound + " position");

            int indexNotFound = Array.IndexOf(numberArrayB, 110);
            Console.WriteLine("Value 110 is located at: " + indexNotFound + " position");

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Array C before Reverse");

            for (int i = 0; i < numbersArrayC.Length; i++)
                Console.WriteLine(numbersArrayC[i]);

            Console.WriteLine("Array C after Reverse");

            Array.Reverse(numbersArrayC);

            for (int i = 0; i < numbersArrayC.Length; i++)
                Console.WriteLine(numbersArrayC[i]);

            Console.WriteLine("-----------------------------------------");

            // Number of elements: 5
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Array.Resize(ref numbers, 6);
            numbers[5] = 10;

            Console.WriteLine("After resize");
            // Number of elements: 6
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);

            Console.WriteLine("Ok");

            string[] participantNames = new string[] { "Igor", "Nikola", "David", "Milan", "Marko", "Zoran", "Miroslav", "Almir" };

            Console.WriteLine("This course participants are: ");

            foreach (string participant in participantNames)
            {
                Console.WriteLine(participant);
            }

            /*
             #4
             Declare 5 arrays with 5 elements in them:​
             - With words​
             - With decimal values​
             - With characters from keyboard​
             - With true/false values​
             - With arrays, each holding 2 whole numbers
             
            #5
            Declare a new array of integers with 5 elements​
            Initialize the array elements with values from input​
            Sum all the values and print the result in the console​

            #6
            Create an array with names​
            Give an option to the user to enter a name from the keyboard​
            After entering the name put it in the array​
            Ask the user if they want to enter another name(Y / N)​
            Do the same process over and over until the user enters N​
            Print all the names after user enters N​
             
             */

            /*
            Declare a new array of integers with 5 elements​
            Initialize the array elements with values from input​
            Sum all the values and print the result in the console​
             */

            Console.WriteLine("**************************************");

            int[] integersArray = new int[5];

            for (int i = 0; i < integersArray.Length; i++) 
            {
                int userInput = 0;

                Console.WriteLine("Unesite broj: ");
                userInput = Convert.ToInt16(Console.ReadLine());

                integersArray[i] = userInput;
            }

            int sum = 0;

            foreach (int item in integersArray)
                sum = sum + item;

            Console.WriteLine("Sum is: " + sum);


            #region Exercise 4 - 6
            // Exercise 4
            string[] words = new string[] { "Hello", "Hi", "Wow", "Words", "Dinosaur" };
            double[] decimals = new double[] { 2.4, 5.4444, 0.00009, 18.9, 999.0002 };
            char[] characters = new char[] { 'b', 'c', '0', '#', ']' };
            bool[] booleans = new bool[] { true, false, false, true, false };
            int[][] arraysOfInts = new int[][] {
                new int[] {2, 4},
                new int[] {-6, 12},
                new int[] {0, 99},
                new int[] {32, 27},
                new int[] {9999, 50}
            };

            // Exercise 5 Solution 1
            int[] arrayOfIntegers1 = new int[5];
            int sum1 = 0;
            for (int i = 0; i < arrayOfIntegers1.Length; i++)
            {
                Console.WriteLine("Enter index " + i);
                int number = int.Parse(Console.ReadLine());
                arrayOfIntegers1[i] = number;
            }
            foreach (int num in arrayOfIntegers1) sum1 += num;
            Console.WriteLine("The result is: " + sum1);
            Console.ReadLine();

            // Exercise 5 Solution 2
            int[] arrayOfIntegers2 = new int[5];
            int sum2 = 0;
            int j = 0;
            while (j < arrayOfIntegers2.Length)
            {
                Console.WriteLine("Enter index " + j);
                if (!int.TryParse(Console.ReadLine(), out arrayOfIntegers2[j]))
                {
                    Console.WriteLine("That was not a number!");
                    continue;
                };
                sum2 += arrayOfIntegers2[j];
                j++;
                if (j == arrayOfIntegers2.Length) Console.WriteLine("The result is: " + sum2);
            }
            Console.ReadLine();

            // Exercise 6 
            string[] fullNames = new string[0];
            int counter = 0;
            while (true)
            {
                Console.WriteLine("Please enter a name from the keyboard:");
                string name = Console.ReadLine();
                Array.Resize(ref fullNames, fullNames.Length + 1);
                fullNames[counter] = name;
                Console.WriteLine("Names stored:");
                foreach (string currentName in fullNames)
                {
                    Console.WriteLine(currentName);
                }
                Console.WriteLine("Do you want to enter another name?");
                if (Console.ReadLine() == "N") break;
            }
            #endregion


            Console.ReadLine();


        }
    }
}