namespace _1D_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Random rnd = new Random();
            int rndNum;

            int cols = 8;
            int[] table = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                table[j] = rnd.Next(1, 100);  // creates a number between 1 and 99;
            }



            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine(table[j]); 
            }

            int counter = 0;
            do
            {
                Console.WriteLine("value of a:" + counter + " is " + table[counter]);
                counter += 1;
            }
            while (counter < cols);

            foreach (var value in table)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}