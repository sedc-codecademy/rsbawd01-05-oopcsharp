namespace Arrays_1D_FindDup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count duplicated number!");
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[100];
            int s1, s2, mm = 1, ctr = 0;
            int i, j;
            Console.Write("\n\nCount total number of duplicate elements in an array:\n");
            Console.Write("---------------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", s1);
            for (i = 0; i < s1; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /*----------------- copy in other array ------------------------------------*/
            for (i = 0; i < s1; i++)
            {
                arr2[i] = arr1[i];
                arr3[i] = 0;
            }
            /*------------------- mark the elements are duplicate -------------------------*/
            for (i = 0; i < s1; i++)
            {
                for (j = 0; j < s1; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[j] = mm;
                        mm++;
                    }
                }
                mm = 1;
            }
            /*--------------- Prints the array ------------------------------------*/
            for (i = 0; i < s1; i++)
            {
                if (arr3[i] == 2) { ctr++; }
            }
            Console.Write("The number of duplicate elements is: {0} \n", ctr);

            Console.Write("\n\n");

        }
    }
}