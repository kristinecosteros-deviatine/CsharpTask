using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Total Students: ");
        int totalStudents = int.Parse(Console.ReadLine());

        string[] names = new string[totalStudents];
        int[,] subjects= new int[totalStudents, 3];
        int[] totalMarks = new int[totalStudents];

        // INPUT
        for (int i = 0; i < totalStudents; i++)
        {
            Console.WriteLine("\nStudent " + (i + 1));

            Console.Write("Student Name: ");
            names[i] = Console.ReadLine();

            Console.Write("Enter English Marks(Out of 100): ");
            subjects[i, 0] = int.Parse(Console.ReadLine());

            Console.Write("Enter Math Marks(Out of 100): ");
            subjects[i, 1] = int.Parse(Console.ReadLine());

            Console.Write("Enter Computer Marks(Out of 100): ");
            subjects[i, 2] = int.Parse(Console.ReadLine());

            totalMarks[i] = subjects[i, 0] + subjects[i, 1] + subjects[i, 2];
        }

        // SORT (Descending)
        for (int i = 0; i < totalStudents - 1; i++)
        {
            if (totalMarks[i] < totalMarks[i + 1])
            {
                int tempTotal = totalMarks[i];
                totalMarks[i] = totalMarks[i + 1];
                totalMarks[i + 1] = tempTotal;

                string tempName = names[i];
                names[i] = names[i + 1];
                names[i + 1] = tempName;
            }
        }

        // OUTPUT
        Console.WriteLine("REPORT CARD");
        for (int i = 0; i < totalStudents; i++)
        {
            Console.WriteLine(
                "Name: " + names[i] +
                " | Position: " + (i + 1) +
                " | Total: " + totalMarks[i] + "/300"
            );
        }
    }
}