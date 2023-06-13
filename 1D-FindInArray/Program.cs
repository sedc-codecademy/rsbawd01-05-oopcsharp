namespace _1D_FindInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# program to search element in an array
            int size, i, toSearch, found;


            /* Input array size */
            Console.Write("Enter size of array : ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            /* Input elements in array */
            Console.WriteLine("Enter {0} elements in the array", size);
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nEnter element to search: ");
            toSearch = Convert.ToInt32(Console.ReadLine());

            /* Assume that element does not exists in array */
            found = 0;

            for (i = 0; i < size; i++)
            {
                /* 
                 * If element is found in array then raise found flag
                 * and terminate from loop.
                 */
                if (arr[i] == toSearch)
                {
                    found = 1;
                    break;
                }
            }

            /*
             * If element is not found in array
             */
            if (found == 1)
            {
                Console.Write("\n{0} is found at position {1}", toSearch, i + 1);
            }
            else
            {
                Console.Write("\n{0} is not found in the array", toSearch);
            }
            Console.ReadLine();

        }
    }
}