namespace _0L_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do While loop!");
            /* local variable definition */
            int a = 10;

            /* do loop execution */
            do
            {
                Console.WriteLine("value of a: {0}", a);
                a = a + 1;
            }
            while (a < 20);
            Console.ReadLine();

        }
    }
}