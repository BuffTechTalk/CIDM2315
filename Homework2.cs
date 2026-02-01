namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1
        
        Console.WriteLine("Please input a letter grade: ");
        string? letterGrade = Console.ReadLine()?.ToUpper();
        switch (letterGrade)
        {
            case "A":
            Console.WriteLine("GPA: 4.0");
            break;
            case "B":
            Console.WriteLine("GPA: 3.0");
            break;
            case "C":
            Console.WriteLine("GPA: 2.0");
            break;
            case "D":
            Console.WriteLine("GPA: 1.0");
            break;
            case "F":
            Console.WriteLine("GPA: 0");
            break;
            default:
            Console.WriteLine("Wrong Letter Grade!");
            break;
        }

        // Code for Q2

        int n1 = 12, n2 = 11, n3 = 14;
        Console.WriteLine("Please input the first num: 12");
        string? firstAnswer = Console.ReadLine();
        int firstNumber = Convert.ToInt32(firstAnswer);

        Console.WriteLine("Please input the second num: 11");
        string? secondAnswer = Console.ReadLine();
        int secondNumber = Convert.ToInt32(secondAnswer);

        Console.WriteLine("Please input the third num: 14");
        string? thirdAnswer = Console.ReadLine();
        int thirdNumber = Convert.ToInt32(thirdAnswer);

        if(n1==firstNumber && n2==secondNumber && n3==thirdNumber)
        {
            Console.WriteLine($"The smallest value is: {n2}");
        }
        else{
            Console.WriteLine("Wrong number entered.  Please enter correct numbers.");
        }

        // Code for Bonus Question

        Console.WriteLine("Please input a year: ");
        string? yearAnswer = Console.ReadLine();
        int leapYear = Convert.ToInt32(yearAnswer);
        if ((leapYear % 4 == 0 && leapYear % 100 != 0) || leapYear % 400 == 0)
        {
            Console.WriteLine($"{yearAnswer} is a leap year!");
        }
        else{
            Console.WriteLine($"{yearAnswer} is not a leap year.");
        }

    }
}
