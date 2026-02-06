using System;

public class Student
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }

    // Methods
    public void DisplayInfo()
    {
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Grade: " + Grade);
    }

    public bool IsPassed()
    {
        return Grade >= 75;
    }
}

public class Task6
{
    public static void Main(string[] args)
    {
        Student student = new Student();

        student.Name = "Kristine";
        student.Age = 20;
        student.Grade = 85.5;

        // Calls
        student.DisplayInfo();

        if (student.IsPassed())
        {
            Console.WriteLine("Status: Passed");
        }
        else
        {
            Console.WriteLine("Status: Failed");
        }
    }
}