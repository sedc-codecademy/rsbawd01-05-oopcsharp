namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHello("Zoran", 17);
            SayHello("Almir", 28);
            SayHello("Miroslav", 20);

            SayHello("Biljana", 20);

            Console.WriteLine("-------------------------------");

            string response = SayHello("Almir Vuk");
            string response2 = SayHello("Zoran Malinovic");


            string response3 = response2 + " best assistent ever!";

            Console.WriteLine(response);
            Console.WriteLine(response3);

            string responseX = SayHello("Miroslav");

            }

        public static void SayHello(string name, int age) 
        {
            Console.WriteLine("**********");
            Console.WriteLine(name);
            Console.WriteLine("**********");
            Console.WriteLine("Godina: " + age);
            Console.WriteLine("**********");
        }

        public static string SayHello(string name) 
        {
            string result = $"Hello there {name}!";

            return result;
        }
    }
}