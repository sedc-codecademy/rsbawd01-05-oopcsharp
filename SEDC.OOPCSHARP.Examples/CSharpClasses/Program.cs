using CSharpClasses.Models;

namespace CSharpClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Almir";
            person1.LastName = "Vuk";
            person1.Age = 28;

            Person person2 = new Person("Zoran", "Malinovic", 40);

            Person person3 = new Person();
            person3.FirstName = "Miroslav";
            person3.LastName = "Popovic";
            person3.Age = 40;

            person1.IntroduceYourSelf();
            person2.IntroduceYourSelf();
            person3.IntroduceYourSelf();

            Vehicle bmw = new Vehicle();

            DateTime danas = new DateTime(2023, 6, 15);
            DateTime sutra = new DateTime(2023, 6, 16);

            bmw.Year = 2020;
            bmw.Model = "340i";
            bmw.Make = "BMW";
            bmw.HorsePower = 380;

            Vehicle polo = new Vehicle();
            polo.Year = 2010;
            polo.Make = "VW";
            polo.Model = "6R";
            polo.HorsePower = 95;
            polo.Color = "Red";

            Console.WriteLine($"{polo.Make} {polo.Model} - {polo.Year} - HP: {polo.HorsePower}" );
            Console.WriteLine($"{bmw.Make} {bmw.Model} - {bmw.Year} - HP: {bmw.HorsePower}" );

            #region Exercise 3
            Student[] arrStudents = new Student[] {
                new Student("Bob", "G1", "Web Developemt"),
                new Student("Jill", "G2", "Design"),
                new Student("Greg", "G1", "Networks"),
                new Student("Anne", "G3", "Web Developemt"),
                new Student("Will", "G3", "Design")
            };

            Console.WriteLine("Enter a student name");
            string studentName = Console.ReadLine();
            FindStudent(arrStudents, studentName);
            #endregion

            #region Exercise 2

            Dog aDog = new Dog();

            Console.WriteLine("Enter the dog's name");
            aDog.Name = Console.ReadLine();

            Console.WriteLine("Enter the dog's race");
            aDog.Race = Console.ReadLine();

            Console.WriteLine("Enter the dog's color");
            aDog.Color = Console.ReadLine();

            Console.WriteLine("What do you want the dog to do: \n 1. Feed the dog \n 2. Play \n 3. Let it chase it's tail");
            int result = Int32.Parse(Console.ReadLine());

            DogOptions(aDog, result);

            #endregion

            #region Exercise 1

            Human human1 = GetHumanInfo();
            Human human2 = GetHumanInfo();
            Human human3 = GetHumanInfo();

            Console.WriteLine(human1.GetPersonStats());
            Console.WriteLine(human2.GetPersonStats());
            Console.WriteLine(human3.GetPersonStats());

            #endregion
        }
 
        public static Human GetHumanInfo() 
        {
            Human human = new Human();

            Console.Write("Enter human first name:");
            human.FirstName = Console.ReadLine();

            Console.Write("Enter human last name:");
            human.LastName = Console.ReadLine();

            Console.Write("Enter human age:");
            human.Age = int.Parse(Console.ReadLine());

            return human;
        }

        public static void DogOptions(Dog dog, int option)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine(dog.Eat());
                    break;
                case 2:
                    Console.WriteLine(dog.Play());
                    break;
                case 3:
                    Console.WriteLine(dog.ChaseTail());
                    break;
                default:
                    Console.WriteLine("No option like that. Sorry.");
                    break;
            }
            Console.ReadLine();
        }
  
        public static void FindStudent(Student[] students, string name)
        {
            bool studentFound = false;
            while (studentFound == false)
            {
                foreach (var student in students)
                {
                    if (name.ToLower() == student.Name.ToLower())
                    {
                        Console.WriteLine($"Student found: \n Name: {student.Name} \n Group: {student.Group} \n Academy: {student.Academy}");
                        studentFound = true;
                    }
                }
                if (studentFound == false)
                {
                    Console.WriteLine("There is no such student, please try again");
                    name = Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}