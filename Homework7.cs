namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        //Q1 & Q2 Answer //first customer listed with id, name, age
        Customer Alice = new Customer(110, "Alice", 28);
        //Q1 & Q2 Answer //printing first customer's info
        Alice.PrintCusInfo();

        //Q1 & Q2 Answer //second customer listed with id, name, age
        Customer Bob = new Customer(111, "Bob", 30);
        //Q1 & Q2 Answer //printing second customer's info
        Bob.PrintCusInfo();

        //Q1 Answer //updating id on first customer
        Alice.ChangeID(220);
        //Q1 Answer //updating id on second customer
        Bob.ChangeID(221);
        //printing the updated id's on both customers
        Alice.PrintCusInfo();
        Bob.PrintCusInfo();

        //Q1 Answer //method comparing age between both customers
        Alice.CompareAge(Bob);
    }
}
//customer class variables for id, name, age. id is set to private
class Customer
{
    public int cus_id {get;private set;}
    public string cus_name;
    public int cus_age;
    //customer object with id, name, age
    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_age = cus_age;
        this.cus_name = cus_name;
    }
    //method to print customer info: id, name, age
    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age:{cus_age}");
    }
    //setting new value for updated id change
     public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }
    //method used to compare ages of customers and print which one is oldest
    public void CompareAge(Customer objCustomer)
    {
        if(this.cus_age >= objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older");
        }
        else
        {
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
    }
}