using System.Runtime.InteropServices;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For loop
            Console.WriteLine("Counting to 10...");

            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine("Counter is now: " + i);
            }

            Console.WriteLine("We are done counting");

            Console.WriteLine("Counting from 10 to zero ...");

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Counter is now: " + i);
            }

            //While loop

            int x = 0;

            while (x < 100)
            {
                Console.WriteLine("This is running " + x);
                x++;
            }

            Console.WriteLine("While loop is done");


            int z = 10;

            // do-while loop
            do
            {
                Console.WriteLine("This is running (do while) " + x);
                z++;

            } while (z < 100);

            Console.WriteLine("Do While loop is done");


            /* 
            #1
               Get an input number from the console​ 
               Print all numbers from 1 to that number​ 
               Get another input number from the console​ 
               Print all numbers from that number to 1​ ​ ​
             */

            int numA = 0;
            
            Console.WriteLine("Please input number: ");
            numA = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= numA; i++)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();

            int numB = 0;

            Console.WriteLine("Please input number: ");
            numB = Convert.ToInt16(Console.ReadLine());

            for (int i = numB; i >= 1; i--)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();


            /* 
             * #2 
               Get an input number from the console​
               Print all even numbers starting from 2​
               Get another input number from the console​
               Print all odd numbers starting from 1​
             */


            int numC = 0;

            Console.WriteLine("Please input number: ");
            numC = Convert.ToInt16(Console.ReadLine());

            // #1 solution
            for(int i = 2;  i <= numC; i++) 
            {
                if (i % 2 == 0)
                    Console.Write(i + ", ");
            }

            // #2 solution
            for (int i = 2; i <= numC; i+=2)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();

            int numD = 0;

            Console.WriteLine("Please input number: ");
            numD = Convert.ToInt16(Console.ReadLine());

            // #1 solution
            for (int i = 1; i <= numD; i++)
            {
                if (i % 2 != 0)
                    Console.Write(i + ", ");
            }

            // #2 solution
            for (int i = 1; i <= numD; i+=2)
            {
                if (i % 2 != 0)
                    Console.Write(i + ", ");
            }

            /* 
             * #3
            
            Get an input from the console​
              Print all numbers from 1 to that number​
              Don’t print numbers that can be divided by 3 or 7​
              If the number gets to 100 print a message: The limit is reached and stop counting​

             */

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");

            int numE = 0;

            Console.WriteLine("Please input number: ");
            numE = Convert.ToInt16(Console.ReadLine());

            // #1 solution
            for (int i = 1; i <= numE; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                    continue;

                Console.Write(i + ", ");

                if (i == 100)
                {
                    Console.WriteLine("The limit is reached​");
                    break;
                }
            }


            // to keep console running 

            Console.ReadLine();
        }
    }
}