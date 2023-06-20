namespace Inheritance.Models
{
    public class Professor : Person
    {
        public string[] Courses { get; set; }

        // Other specific properties
        // ...

        public override void PrintInfo()
        {
            base.PrintInfo();

            Console.WriteLine("My courses are: ");

            foreach (string item in Courses)
                Console.WriteLine($" - {item}");
        }
    }
}
