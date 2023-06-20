using Enums.EnumHelpers;
using System.Drawing;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserColor userSelectedColor = 0;

            Console.WriteLine("Pick a color:\n1. Red\n2. Green\n3. Blue\n4. Yellow\n5. YellowGreen");

            int userChoice = int.Parse(Console.ReadLine());

            userSelectedColor = (UserColor) userChoice;

            Console.WriteLine("Saving data to database....");

            // Imagine that this value is saved into database table called
            // UserPreferences for Column, SelectedColor

            // Retriving the data from database we will call the method ReadUserSelected
            // to dispaly data to the user

            Console.WriteLine("Reading data from database....");

            ReadUserSelected(userSelectedColor);

            Gender genderM = Gender.Male;
            Gender genderF = Gender.Female;

            Permissions permissions = Permissions.None;
            Permissions permissionsW = Permissions.Write;
            Permissions permissionsR = Permissions.Read;
        }

        public static void ReadUserSelected(UserColor userColor) 
        { 
            switch (userColor)
            {
                 case UserColor.Red:
                    Console.WriteLine("User selection was Red");
                    break;

                case UserColor.Green:
                    Console.WriteLine("User selection was Green");
                    break;

                case UserColor.Blue:
                    Console.WriteLine("User selection was Blue");
                    break;

                case UserColor.Yellow:
                    Console.WriteLine("User selection was Yellow");
                    break;

                case UserColor.YellowGreen:
                    Console.WriteLine("User selection was YellowGreen");
                    break;
            }
        
        }
    }
}