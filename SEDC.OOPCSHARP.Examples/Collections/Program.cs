using Collections.Models;
using System.Collections;
using System.Globalization;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -- Generic Collections: List

            // Empty list of strings
            List<string> names = new List<string>();

            // in order to add something call method .Add(...)
            names.Add("Zoran");
            names.Add("Miroslav");
            names.Add("Biljana");

            foreach (string element in names)
                Console.WriteLine(element);

            Console.WriteLine("... Removing Zoran");

            // in order to remove something call method .Remove(...)
            names.Remove("Zoran");

            Console.WriteLine("....................");

            foreach (string name in names)
                Console.WriteLine(name);

            // other way to add elements in the first step 
            List<int> numbers = new List<int>() { 1, 2, 3, 5, 8, 11, 19, 2, 3, 4, 5 };

            Console.WriteLine("Numbers: ");
            foreach (int num in numbers)
                Console.WriteLine(num);

            string nameB = names.Find(n => n == "Biljana");
            string nameZ = names.Find(n => n == "Zoran");

            int countOfElements = names.Count;

            // -- Generic Collections: Dictionary

            Dictionary<int, string> people = new Dictionary<int, string>();

            people.Add(1, "Miroslav");
            people.Add(10, "Dalibor");
            people.Add(13, "Biljana");
            people.Add(15, "Zoran");
            people.Add(25, "David");
            people.Add(12, "Milan");
            people.Add(11, "Vitomir");

            foreach (var element in people) 
                Console.WriteLine($"{element.Key} - {element.Value}");

            // remove element with the value of key: 12
            Console.WriteLine("... Removing Milan");
            people.Remove(12);

            if (people.ContainsKey(10))
                Console.WriteLine("There is an element with the value of key: 10");

            if (people.ContainsKey(99))
                Console.WriteLine("There is an element with the value of key: 99");
            else
                Console.WriteLine("There is NO element with the value of key: 99");

            if (people.ContainsValue("Zoran"))
                Console.WriteLine("There is an element with the value: Zoran");
            else
                Console.WriteLine("There is NO element with the value: Zoran");

            // Total number of elements in this dictionary
            int numberOfPeopleElements = people.Count;

            string element15 = people[15];

            Console.WriteLine($"Element with the value of key: 15, has value: {element15}");

            Console.WriteLine($"The first element is {people.First().Key} - {people.First().Value}");
            Console.WriteLine($"The last element is {people.Last().Key} - {people.Last().Value}");

            // -- Generic Collections: Queue
            Console.WriteLine("........... Queue ............");

            // Empty queue
            Queue<string> peopleQ = new Queue<string>();

            // Add element to the queue
            peopleQ.Enqueue("Almir");
            peopleQ.Enqueue("Zoran");
            peopleQ.Enqueue("David");
            peopleQ.Enqueue("Dalibor");
            peopleQ.Enqueue("Igor");

            Console.WriteLine("\n.....Before Dequeue");
            foreach (string item in peopleQ)
                Console.WriteLine(item);

            // Removes the correct element respecting the FIFO (First in, first out) style
            peopleQ.Dequeue();

            Console.WriteLine("\n.....After Dequeue\n........\n");
            foreach (string item in peopleQ)
                Console.WriteLine(item);

            // Returns the next item in the queue
            Console.WriteLine($"Next item for Dequeue is: {peopleQ.Peek()}");

            // -- Generic Collections: Stack
            Console.WriteLine("........... Stack ............");

            // Empty stack created
            Stack<string> peopleS = new Stack<string>();

            // Add elements to the Stack
            peopleS.Push("Almir");
            peopleS.Push("Zoran");
            peopleS.Push("David");
            peopleS.Push("Dalibor");
            peopleS.Push("Igor");

            Console.WriteLine("\n.....Before Pop");
            foreach (string item in peopleS)
                Console.WriteLine(item);

            // Removes the correct element respecting the LIFO (Last in, first out) style
            peopleS.Pop();

            Console.WriteLine("\n.....After Pop");

            foreach (string item in peopleS)
                Console.WriteLine(item);

            // Returns the next item for pop (remove)
            Console.WriteLine($"Next item for Pop is: {peopleS.Peek()}");
        }
    }
}