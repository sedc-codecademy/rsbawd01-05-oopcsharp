namespace ParsingData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberA = 0;
            double numberB = 0;

            Console.WriteLine("First number: ");

            string numberAString = Console.ReadLine();
            numberA = Convert.ToDouble(numberAString);

            Console.WriteLine("Second number: ");

            string numberBString = Console.ReadLine();
            numberB = Convert.ToDouble(numberBString);

            char operation;

            Console.WriteLine("Please select the math operation you want? +, -, *, /");
            operation = char.Parse(Console.ReadLine());

            Console.WriteLine("The result is: ");

            if (operation == '+')
            {
                Console.WriteLine("a + b = " + (numberA + numberB));
            }

            if (operation == '-')
                Console.WriteLine("a - b = " + (numberA - numberB));

            if (operation == '*')
                Console.WriteLine("a * b = " + (numberA * numberB));

            if (operation == '/')
            {
                Console.WriteLine("a / b = " + (numberA / numberB));
            }

            // IF-ELSE IF - ELSE
            if (numberA == numberB)
            {
                Console.WriteLine("Ovi brojevi su jednaki");
            }
            else 
            { 
                Console.WriteLine("Ovi brojevi su nisu jednaki");
            }

            if (numberA > numberB)
            {
                Console.WriteLine("A je vece od B");
            }
            else if (numberA < numberB) 
            { 
                Console.WriteLine("A je manje od B");
            }
            else
            {
                Console.WriteLine("Ovi brojevi su jednaki");
            }


            int day = 0;

            Console.WriteLine("Select the day of week: 1,2,3,4,5,6,7");

            day = Convert.ToInt32(Console.ReadLine());

            switch (day) 
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                        
                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;
                
                case 6:
                    Console.WriteLine("Saturday");
                    break;
               
                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Non standard value selected");
                    break;
            }

            switch (day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Work day");
                    break;

                case 6: 
                case 7:

                    Console.WriteLine("Weekend day");
                    break;

                default:
                    Console.WriteLine("Non standard value selected");
                    break;
            }

            if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
                Console.WriteLine("Work day");

            else if (day == 6 || day == 7)
                Console.WriteLine("Weekend day");
            
            else 
                Console.WriteLine("Non standard value selected");

            // int numberX = int.Parse(numberAString);
            //bool isSucced = int.TryParse(numberAString, out int numberY);

        }
    }
}