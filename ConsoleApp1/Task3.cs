using System;

class Task3
{
    public static void Run()
    {
        int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };
        Console.Write("Enter a Number: ");
        int userInput = int.Parse(Console.ReadLine());
         bool found= false;

        for (int x = 0; x < numbers.Length; x++)
        {
            if (numbers[x] == userInput)
            {
                Console.WriteLine("Number found at position x " + x);
                found = true;
                break;


            }
         }         
         if (!found)
        {
            Console.WriteLine("Number not found in the list");
        }
    }
}
    