 class Task4
{
    public static void Run()
    {
        string again = "Y";

        while (again == "Y")
        {
            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.WriteLine("1  Addition (+)");
            Console.WriteLine("2  Subtraction (-)");
            Console.WriteLine("3  Multiplication (*)");
            Console.WriteLine("4  Division (/)");

            Console.Write("Please Enter a Arithmetic Operators: ");
            int userInput = int.Parse(Console.ReadLine());

            Console.Write("Enter Value 1: ");
            int value1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Value 2: ");
            int value2 = int.Parse(Console.ReadLine());
            int result;
            switch (userInput)
            {
                case 1: result= value1+value2;
                    Console.WriteLine($"{value1} + {value2} = {result}");
                    break;

                case 2: 
                result= value1 - value2;
                  Console.WriteLine($"{value1} - {value2} = {result}");
                    break;

                case 3: result = value1*value2;
                    Console.WriteLine($"{value1} * {value2} = {result}");
                    break;

                case 4: result= value1/ value2;
                    Console.WriteLine($"{value1} / {value2} = {result}");
                    break;

                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }

            Console.Write("Do you want to continue again (Y/N)? ");
            again = Console.ReadLine().ToUpper();
        }
    }
}