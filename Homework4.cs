namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        //Call Q1_method()
        int largestNumber = CompareNumbers();
        Console.WriteLine($"The largest number is: {largestNumber}");

        Console.WriteLine("-----------------------------------");

        //Call Q2_method()
        Triangle();
    }
    
    //Q1_method
    static int CompareNumbers()
    {
        Console.WriteLine("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int max_num;
        if (num1 > num2)
        {
            max_num = num1;
        }
        else 
        {
            max_num = num2;
        }
        return max_num;
    }

    //Q2_method
    static void Triangle()
    {
        Console.WriteLine("Choose a number: (N)");
        int userNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pick one:  Left or Right");
        string? userChoice = Console.ReadLine()?.ToLower();

        for (int row = 0; row < userNumber; row++)
        {
            for (int column = 0; column < userNumber; column++)
            {
                if (userChoice == "left")
                {
                    if (column <= row)
                    Console.Write("*");

                    else
                    Console.Write(" ");
                }
                else if (userChoice == "right")
                {
                    if (column >= (userNumber - 1 - row))
                    Console.Write("*");
                    
                    else
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
    
}
