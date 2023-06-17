using Task33.Models;

namespace Task33
{
    internal class Program
    {
        static User[] users = new User[]
        {
            new User(){Id = 24, Username = "Bob23", Password = "mysuperpass", Messages = new string[]{"Hey bob! Nice shirt.", "Call me pls!" } },
            new User(){Id = 12, Username = "Jill_awesome", Password = "123456", Messages = new string[]{"How are ya? Call me", "When will you go to work?", "Your card is ready!" }},
            new User(){Id = 5, Username = "GregGregsky", Password = "lozinka", Messages = new string[]{"Come to my party tomorrow!", "Drunk message. Please don't take it seriously." }}
        };

        static void Main(string[] args)
        {
            bool next = true;

            do
            {
                Console.WriteLine("........................................");

                Console.WriteLine("Welcome, choose number option to continue:");
                Console.WriteLine("1. Log in");
                Console.WriteLine("2. Register");

                int userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 1)
                    Login();

                if (userChoice == 2)
                    Register();

                Console.WriteLine("........................................");

                Console.WriteLine("Do you want to continue? Y/N");

                if (Console.ReadLine() == "N")
                    next = false;
               else
                    next = true;

            } while (next);
        }

        static void Login()
        {
            string username;
            string password;

            Console.WriteLine("..............................");
            Console.WriteLine("Login:");

            Console.Write("Username: ");
            username = Console.ReadLine();

            Console.Write("Password: ");
            password = Console.ReadLine();

            Console.WriteLine("..............................");

            User foundUser = null;

            foreach (User userElement in users)
            {
                if (userElement.Username == username &&
                    userElement.Password == password)
                    foundUser = userElement;
            }

            if (foundUser == null)
            {
                Console.WriteLine("There is no user with that username or password");
                return;
            }

            Console.WriteLine("*******************************************");

            Console.WriteLine($"Welcome, {foundUser.Username}");

            if (foundUser.Messages != null)
            {
                foreach (string msg in foundUser.Messages)
                    Console.WriteLine($" - {msg}");
            }
            else
            {
                Console.WriteLine("No messages recorded");
            }

            Console.WriteLine("*******************************************");
        }

        static void Register()
        {
            string username;
            string password;

            Console.WriteLine("..............................");
            Console.WriteLine("Register:");

            Console.Write("Username: ");
            username = Console.ReadLine();

            Console.Write("\nPassword:");
            password = Console.ReadLine();

            Console.WriteLine("..............................");

            bool exists = false;

            foreach (User userElement in users)
            {
                if (username == userElement.Username)
                    exists = true;
            }

            if (exists)
            {
                Console.WriteLine("User is already registered!");
                return;
            }

            User newUser = new User();
            newUser.Username = username;
            newUser.Password = password;

            Array.Resize(ref users, users.Length + 1);

            int lastAvailableIndex = users.Length - 1;

            users[lastAvailableIndex] = newUser;

            Console.WriteLine("................................");
            Console.WriteLine("Successfuly, added new user! Registration completed");
            Console.WriteLine("..............................");
            Console.WriteLine("Users:");

            foreach (User user in users)
                Console.WriteLine($"- {user.Username}");

            Console.WriteLine("..............................");
        }
    }
}