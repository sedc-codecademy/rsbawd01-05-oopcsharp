namespace FindLongestWordInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find The Longest Word in String Array");

            string[] msgArr = { "Send data", "Message arr", "Calculate data", "SEDC Code Academy C# basic", "Play" };
            string longestWord = "";
            int wordCount = 0;
            foreach (string item in msgArr)
            {
                if (item.Length > wordCount)
                {
                    wordCount = item.Length;
                    longestWord = item;
                }
            }

            Console.WriteLine("The longest word: " + longestWord);
            Console.WriteLine("Letters count : " + wordCount);
            Console.ReadLine();
        }
    }
}