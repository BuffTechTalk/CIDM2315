namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        //Call Q1_method()
        int num1, num2, max1;
        
        //asking user for 2 numbers, comparing those numbers and putting out largest number
        Console.WriteLine("Enter two numbers: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        max1 = GetNumbers(num1,num2);
        Console.WriteLine($"The largest number is: {max1}");

        Console.WriteLine("-------------------------------");

        //Call Q2_method()
        int num3, num4, max;
        
        //asking user for 4 numbers, comparing those numbers and putting out largest number
        Console.WriteLine("Enter 4 numbers: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        num3 = Convert.ToInt32(Console.ReadLine());
        num4 = Convert.ToInt32(Console.ReadLine());
        max = GetNumbers(num1, num2, num3, num4);
        Console.WriteLine($"The largest number is: {max}");

        Console.WriteLine("--------------------------------");

        //Call Q3_method()
        string? userName;
        string? password;
        string? passwordCheck;
        int birthYear;

        //asking user for username, password, re-enter same password, and birthyear
        Console.WriteLine("Enter Your Username: ");
        userName = Console.ReadLine();
        Console.WriteLine("Enter Your Password: ");
        password = Console.ReadLine();
        Console.WriteLine("Enter Your Password Again: ");
        passwordCheck = Console.ReadLine();
        Console.WriteLine("Enter Your Birthyear: ");
        birthYear = Convert.ToInt32(Console.ReadLine());

        CreateAccount(userName, birthYear, password, passwordCheck);

    }
    //Q1_method
    //here is the formula for checking the user's 2 numbers for comparison and putting out largest number
    static int GetNumbers(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }
    //Q2_method
    //here is the formula for checking user's 4 numbers, comparing input and putting out largest number
    static int GetNumbers(int num1, int num2, int num3, int num4)
    {
        int max1 = GetNumbers(num1, num2);
        int max2 = GetNumbers(num3, num4);
        int max = GetNumbers(max1, max2);
        return max;
    }
    //Q3_method
    //here is the formula for verifying the user's age.  Looking for 18 and older to accept.
    static bool CheckAge(int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //this is where the user is prompted for username, password - twice for accuracy, and year of birth.  The prompts cross-check passwords for a match on both entries, checks the year of birth to verify the user is 18 and older.  If the passwords don't match, then it will read back wrong password.  If the year of birth verification doesn't meet 18 and older, then the response to user will be could not create an account.  Otherwise, if all goes well the account is created successfully.
    static void CreateAccount(string? userName, int birthYear, string? password, string? passwordCheck)
    {
        bool ageAdult = CheckAge(birthYear);
        bool matchingPasswords = (password == passwordCheck);

        if (ageAdult && matchingPasswords)
        {
            Console.WriteLine("Account created successfully");
        }
        else
        {
            if (!matchingPasswords)
            {
                Console.WriteLine("Wrong password");
            }
            if (!ageAdult)
            {
                Console.WriteLine("Could not create an account");
            }
        }
    }
}
