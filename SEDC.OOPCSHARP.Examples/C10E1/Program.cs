namespace C10E1
{
    internal class Program
    {
        static void Main()
        {
            List<int> grades = new List<int>();

            Console.WriteLine("Calculate Student Grades\n");

            // Get the number of subjects from the user
            Console.WriteLine("Enter the total number of subjects:");
            int numSubjects = int.Parse(Console.ReadLine());

            // Get the grades for each subject
            for (int i = 1; i <= numSubjects; i++)
            {
                Console.WriteLine($"Enter the grade for subject {i}: ");

                int grade = int.Parse(Console.ReadLine());

                grades.Add(grade);
            }

            // Calculate the total marks and average grade
            int totalMarks = CalculateTotalMarks(grades);
            double averageGrade = CalculateAverageGrade(grades);

            Console.WriteLine(".............................");

            // Display the total marks and average grade
            Console.WriteLine($"\nTotal Marks: {totalMarks}");
            Console.WriteLine($"Average Grade: {averageGrade:F2}");

            Console.WriteLine(".............................");
        }

        static int CalculateTotalMarks(List<int> grades)
        {
            int totalMarks = 0;

            foreach (int grade in grades)
                totalMarks = totalMarks + grade; // totalMarks += grade;

            return totalMarks;
        }

        static double CalculateAverageGrade(List<int> grades)
        {
            int totalMarks = CalculateTotalMarks(grades);

            int numSubjects = grades.Count;
            double averageGrade = (double)totalMarks / numSubjects;

            return averageGrade;
        }
    }
}