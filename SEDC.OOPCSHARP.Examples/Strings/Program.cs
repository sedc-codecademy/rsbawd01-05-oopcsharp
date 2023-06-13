using System.Globalization;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Almir";
            string seavus = "from Seavus Academy";

            string hello1 = "Hello " + name + " " + seavus;
            string hello2 = string.Format("Hello {0} {1}", name, seavus);
            string hello3 = $"Hello {name} {seavus}";

            Console.WriteLine(hello1);
            Console.WriteLine(hello2);
            Console.WriteLine(hello3);

            string currency = string.Format("{0:C}", 125.45);
            string percent = string.Format("{0:P}", .55);
            string customFormat = string.Format("{0:0##-###-###}", 62652011);
            string customAlignement = string.Format("| {0, 10} | {1,10} |", "Id", "Order");

            Console.WriteLine(currency);
            Console.WriteLine(percent);
            Console.WriteLine(customFormat);
            Console.WriteLine(customAlignement);

            string a = "Check your C:\\ drive";
            string b = "We will have \"fair\" elections";
            string c = "The \\n sign means: new line";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            string aa = @"Check your C:\ drive";
            string bb = @"We will have ""fair"" elections";
            string cc = @"The \n sign means: new line";

            Console.WriteLine(aa);
            Console.WriteLine(bb);
            Console.WriteLine(cc);

            string helloMessage = "Hello from Almir and Zoran, welcome to, Seavus Academy";

            Console.WriteLine(helloMessage.ToLower());
            Console.WriteLine(helloMessage.ToUpper());

            Console.WriteLine($"Length of this string is: {helloMessage.Length}");

            string[] splitted = helloMessage.Split(',');

            foreach (string element in splitted)
                Console.WriteLine(element);

            bool doesItStartsWithH = helloMessage.StartsWith('H');
            bool doesItStartsWithA = helloMessage.StartsWith('A');

            Console.WriteLine($"Starts with H? {doesItStartsWithH}");
            Console.WriteLine($"Starts with A? {doesItStartsWithA}");

            Console.WriteLine(helloMessage.Substring(11, 5));
            Console.WriteLine(helloMessage.Substring(21, 5));

            string sentence = "   Hello from Academy welcome dear   Students    !   ";

            Console.WriteLine(sentence.Trim());

            SubstringsExercise("Hello from SEDC Codecademy 2023", 10);
        }

        static void SubstringsExercise(string a, int n)
        {
            string result = a.Substring(0, n);
            Console.WriteLine(result+ " " + "length of new string is " + result.Length);
        }
    }
}