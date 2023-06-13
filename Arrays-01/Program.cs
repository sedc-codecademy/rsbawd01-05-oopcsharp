namespace Arrays_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Declare and initialize 2D array.");

            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            Random rnd = new Random();
            int rndNum;

            int rows = 50000;
            int cols = 3000;
            int[,] table = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    table[i, j] = rnd.Next(1, 100);  // creates a number between 1 and 99;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(table[i, j]);
                    Console.Write(", ");
                }
                Console.WriteLine();
            }


            foreach (int s in table)
            {
                Console.Write(s);
                Console.Write(", ");
            }
            Console.WriteLine();

            int sumArr = 0;
            int cntArr = 0;
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int curNum = table[i, j];
                    cntArr += 1;
                    sumArr += curNum;

                    if (curNum > maxNum)
                    {
                        maxNum = curNum;
                    }

                    if (curNum < minNum)
                    {
                        minNum = curNum;
                    }
                }

            }
            double avgArr = 0.0;
            double avgArrBad = 0.0;
            avgArr = Convert.ToDouble(sumArr) / Convert.ToDouble(cntArr);
            avgArrBad = sumArr / cntArr;
            Console.WriteLine("-------------------");

            Console.WriteLine("Number of values: " + cntArr);
            Console.WriteLine("Sum of all values: " + sumArr);
            Console.WriteLine("Max value: " + maxNum);
            Console.WriteLine("Min value: " + minNum);
            Console.WriteLine("Average value: " + avgArr);
            Console.WriteLine("Average value (lose): " + avgArrBad);
            Console.WriteLine("-------------------");

            watch.Stop();

            Console.WriteLine("Execution Time " + watch.ElapsedMilliseconds + " ms");





        }
    }
}