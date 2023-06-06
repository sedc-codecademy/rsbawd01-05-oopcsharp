using System.Globalization;

namespace CSharpDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int firstNum;

            firstNum = 5;

            Console.WriteLine("Variable value is: ");
            Console.WriteLine(firstNum);

            int secondNum = 7;

            Console.WriteLine("Second Variable value is: ");
            Console.WriteLine(secondNum);

            long _55Street;
            
            char intValue;

            int abcw = 10;

            int controlValueNumberThree = 100;

            int ControlValueB = 1001;

            int controlvalue = 99;

            long control_value = 90;

            string firstName;
            firstName = "Zoran";
            firstName = "Almir";
            firstName = "Miroslav";

            Console.WriteLine(firstName);

            // This is error
            // firstName = 99999;


            int firstNumber = 5;
            int secondNumber = 7;

            int result = firstNumber + secondNumber;


            Console.WriteLine(result);
            Console.WriteLine(firstNumber + secondNumber);

            int divisionResult = secondNumber / firstNumber;

            Console.WriteLine("Division:");
            Console.WriteLine(divisionResult);


            /*
             * # 1
             Declare two double variables​
             Initialize them and divide them in a new variable​
             Declare two integer variables​
             Initialize them and divide them in a new variable​
             Print the results in the console and compare​
             */

            // double a1, b1;
            double a1 = 10;
            double b1 = 3;

            double divDoubleValues = a1 / b1;

            int i1 = 10;
            int i2 = 3;

            int resultX = i1 / i2;

            Console.WriteLine("Double division result: " + divDoubleValues);
            Console.WriteLine("Int division result: " + resultX);



            Console.WriteLine("----------------------------------------");
            /*
             * #2
            Declare two string variables​ 
            Initialize them and concatenate them in a new variable​ 
            Declare two string variables​ 
            Initialize them with the number 9 and 3​ 
            Concatenate them in a new variable​ 
            Print the results in the console​
            */

            string firstName1 = "Ime";
            string lastName1 = "Prezime";

            string fullName1 = firstName1 + lastName1;

            Console.WriteLine(fullName1);

            string s1 = "9";
            string s2 = "3";

            string s3 = s1 + s2;

            Console.WriteLine("The result of these numbers is: " + s3);

            Console.WriteLine("----------------------------------------");

            /*
             * #3
             Declare an integer and a string variable​
             Initialize them and concatenate them in a new variable​
             Print the result in the console​
             */

            int number = 9;
            string stringValue;

            stringValue = "Code";

            string resutS = stringValue + number;

            Console.WriteLine(resutS);

            number = 101;

            string resutS2 = stringValue + number;
            Console.WriteLine(resutS2);

            Console.WriteLine("----------------------------------------");

            /*
            * # 4
            You have n credits on your mobile bill. One SMS costs m credits. 
            How many SMS messages you can send?​
            n = 102​
            m = 5​
            Result = ?​
             */

            int credits = 102;
            int messageCost = 5;

            int messagesCount = credits / messageCost;

            Console.WriteLine("Dostupan broj SMS-ova za slanje je: " + messagesCount);
        }
    }
}