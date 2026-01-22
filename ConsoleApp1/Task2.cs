using System; 
class Task2
    {
       public static void Run()
  {
      //Row 0 even numbers
      //Row 1 odd numbers
      int[][] numberMatrix = new int[][]
      {
        new int[]{2,4,6,8,10}, //Row 0
        new int[]{1,3,5,7,9},//Row 1
      };
        Console.WriteLine("The number of matrix has been initialized");
        // extract three specific digits
        int num1 = numberMatrix[1][3]; //7
        int num2 = numberMatrix[0][0]; //2
        int num3 = numberMatrix[1][4]; //9
        //Combined Num into string
        string combinedNum=num1.ToString()+num2.ToString()+num3.ToString();
        //Final Password
        Console.WriteLine("The password is:"+combinedNum);
    }
}
