namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // compile time error example
            // int number = 10

            // run time error example
            // user input: almir

            Console.WriteLine("Input integer number: ");

            try
            {
                int number = int.Parse(Console.ReadLine());

                List<string> list = null;
                list.Add("almir");

                Console.WriteLine(Sqrt(10));
                Console.WriteLine(Sqrt(-10));

                Console.WriteLine(DivideTwoIntegerNumbers(10, 2));
                Console.WriteLine(DivideTwoIntegerNumbers(10, 0));

                Console.WriteLine(DivideTwoNumbers(10, 3));
                Console.WriteLine(DivideTwoNumbers(15, 4));
                Console.WriteLine(DivideTwoNumbers(0, 0));
                Console.WriteLine(DivideTwoNumbers(500, 3));

            }
            catch (FormatException fe) 
            {
                Console.WriteLine("There was a problem with the input ");
                Console.WriteLine($"Error {fe.Message} - {fe.StackTrace}");
            }
            catch(IndexOutOfRangeException ioore) 
            {
                Console.WriteLine("There was a problem with arrray");
                Console.WriteLine($"Error {ioore.Message} - {ioore.StackTrace}");
            }
            catch(NullReferenceException nre) 
            {
                Console.WriteLine("There was a problem with null values");
                Console.WriteLine($"Error {nre.Message} - {nre.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a general problem");
                Console.WriteLine($"Error {ex.Message} - {ex.StackTrace}");
            }

            // optional part
            finally 
            {
                Console.WriteLine("Ja cu se uvijek izvrsitit");
            }

            Console.WriteLine("Rest of the app running");
            Console.WriteLine("End of the app...");
        }

        static double DivideTwoNumbers(double x, double y) 
        {
            if (x == 0 || y == 0)
            {
                Console.WriteLine("Can not be null");

                throw new Exception("Djeljenje sa nulom nije dozvoljeno");
            }

            return x / y;
        }

        static double DivideTwoIntegerNumbers(int x, int y)
        {
            return x / y;
        }

        static double Sqrt(double x) 
        {
            if (x < 0)
                throw new Exception("Korjenovanje sa negativnim brojem je zabranjeno!");

            return Math.Sqrt(x);
        }

    }
}