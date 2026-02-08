namespace Homework3;

class Program
{
    static void Main(string[] args)
    {


        //Code for Q1

        int userNumber;
        bool toPrime = true;
        Console.WriteLine("Input an integer: ");
        userNumber = Convert.ToInt32(Console.ReadLine());

        for (int numberDivided = 2; numberDivided <= (userNumber/2); numberDivided++)
        {
            if ( (userNumber % numberDivided) == 0)
            {
                toPrime = false;
                break;
            }
        }
        if (toPrime)
            Console.WriteLine($"{userNumber} is prime.");
            
        else
            Console.WriteLine($"{userNumber} is non-prime.");


        //Code for Q2
        
        int readBack;
        Console.WriteLine("Enter an integer.");
        readBack = Convert.ToInt32(Console.ReadLine());
        
        for (int row = 0; row<readBack; row++)
        {
            for (int column = 0; column <readBack; column++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }


        //Code for Q3
        
        int lineOutput;
        Console.WriteLine("Input an integer.");
        lineOutput = Convert.ToInt32(Console.ReadLine());

        for (int across = 0; across<lineOutput; across++)
        {
            for (int down = 0; down<lineOutput; down++)
            {
                if (across>=down)
                Console.Write('*');
            }
            Console.WriteLine("");
        }

        // Code for Bonus Question
        
        int n;
        Console.WriteLine("Input a number.");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + "");
            }
            Console.WriteLine();
        }
    }
}
