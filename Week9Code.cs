namespace Week9;
class Program
{

    public static void Main(string[] args) {
        // P4
        // int array with 5 elements
        int[] int_array = new int[5]; 
        Console.WriteLine(int_array);
        // double array with 6 elements
        double[] double_array = new double[6];
        Console.WriteLine(double_array);
        // string array with 10 elements
        string[] string_array = new string[10];
        Console.WriteLine(string_array);
        // bool array with 3 elements
        bool[] bool_array = new bool[3];
        Console.WriteLine(bool_array);

        // P5
        Console.WriteLine("\n--------Page5----------");
        // provide initial values to the array by using curly brackets
        string[] name_arr1 = new string[3] {"Alice", "Bob", "Cathy"};
        double[] price_arr1 = new double[4] {3.6, 9.8, 6.4, 5.9};
        // omit the array size  
        string[] name_arr2 = new string[] {"Alice", "Bob", "Cathy"};
        double[] price_arr2 = new double[] {3.6, 9.8, 6.4, 5.9};
        // even omit the new operator.
        string[ ] name_arr3 = {"John", "Mary", "Jessica"};
        double[ ] price_arr3 = {3.6, 9.8, 6.4, 5.9};

        int[ ] int_arr = {10,15,20,25,30};

        // P7
        Console.WriteLine("\n--------Page7----------");
        for(int idx = 0;idx<5;idx++){
            Console.WriteLine(int_arr[idx]);
        }
        Console.WriteLine("\n--------double a array----------");
        int[] int_arr2 = new int[5];
        for(int idx = 0;idx<5;idx++){
            int_arr2[idx] = int_arr[idx]*2;
        }
        for(int idx = 0;idx<5;idx++){
            Console.WriteLine(int_arr2[idx]);
        }
        Console.WriteLine("\n---------foreach---------");
        foreach(int val in int_arr2){
            Console.WriteLine(val);
        }
        Console.WriteLine("\n------------------");


        // Exercise 1
        Console.WriteLine("\n--------Exercise1----------");
        // inclass exercise 1
        string[] name_array = {"Alice", "Bob", "Cathy", "Tom", "Jack"};
        Console.WriteLine($"the second name is: {name_array[1]}, and the fourth name is: {name_array[3]}");
        name_array[4] = "David";
        foreach(string name in name_array){
            Console.Write($"{name} ");
        }
        Console.WriteLine();
        for(int idx=0;idx<5;idx++){
            Console.Write($"{name_array[idx]} ");
        }
}

    // Part 2: Two-Dimensional Array (2D Array) and Jagged Arrays
   /* The 2d-array can be seen as a table where each row has the same amount of column       
                      1, 2
                      3, 4  
    */  
    // like 1d-array, three ways to declare and initialize 2d-array
    int[,] two_d_array1 = new int[2,2]{{1,2},{3,4}};
    int[,] two_d_array2 = new int[,]{{1,2},{3,4}};
    int[,] two_d_array3 = {{1,2},{3,4}};

    // Iterate 2D array elements
        int[ , ] arr1 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
          };

        for (int row = 0; row < 3; row++) {
          for (int col = 0; col< 3; col++) {
            Console.Write(arr1[row, col]+" ");
          }
          Console.WriteLine();
        }
   // Exercise 2 Sample Code
   static void Main(string[] args)
    {
         int[ , ] arr_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
          };
          Exercise2(arr_2d);
    }
   
    static void Exercise2(int[,] arr_2d){
        Console.WriteLine("--->Method1 with foreach");
        // method 1
        foreach(int val in arr_2d){
            if(val%2==0){
            Console.Write(val +" ");
            }
        }
        // method 2
        Console.WriteLine("\n--->Method2 with nested for loop");
        for (int row = 0; row < 3; row++) {
            for (int col = 0; col<=2; col++) {
            if(arr_2d[row,col]%2==0){
                Console.Write(arr_2d[row, col]+" ");
            }
            }
        }
    }

    // Jagged Array
    int[ ][ ] jaggedArr = new int[ ][ ]
    {
        new int[ ] {1,2,3,4},
        new int[ ] {5,6},
        new int[ ] {7,8,9}
    };
    int num = jaggedArr[2][2];
    Console.WriteLine($"Value of num: {num}");

    


    
// Part 3: Put class objects into Arrays
class Program
{
    static void Main(string[] args)
    {
        Student stu1 = new Student(studentID:111, studentName:"Alice", studentGPA:3.6);
        Student stu2 = new Student(studentID:222, studentName:"Bob", studentGPA:3.5);
        Student stu3 = new Student(studentID:333, studentName:"Cathy", studentGPA:3.1);

        Student[] student_array = {stu1, stu2, stu3};
        // print the first student element in student_array
        Console.WriteLine($"Student 1 - ID: {student_array[0].studentID}; Name: {student_array[0].studentName}; ");
        // try to print the third student element in student_array
    }
}

class Student{
    public int studentID {get; set;} = 0;
    public string studentName {get;set;} = string.Empty;
    public double studentGPA {get;set;} = 0;
    // constructor
    public Student(int studentID, string studentName, double studentGPA){
        this.studentID = studentID;
        this.studentName = studentName;
        this.studentGPA = studentGPA;
    }
}

// iterate objects in Arrays
class Program
{
    static void Main(string[] args)
    {
        Student stu1 = new Student(studentID:111, studentName:"Alice", studentGPA:3.6);
        Student stu2 = new Student(studentID:222, studentName:"Bob", studentGPA:3.5);
        Student stu3 = new Student(studentID:333, studentName:"Cathy", studentGPA:3.1);
        Student[] student_array = {stu1, stu2, stu3};
        foreach(Student stu in student_array){
            stu.printStuInfo();
        }       
    }
}

class Student{
    public int studentID {get; set;} = 0;
    public string studentName {get;set;} = string.Empty;
    public double studentGPA {get;set;} = 0;
        public void printStuInfo(){
        Console.WriteLine($"Student ID: {studentID}; Student Name: {studentName}; Student GPA: {studentGPA}");
    }
    // constructor
    public Student(int studentID, string studentName, double studentGPA){
        this.studentID = studentID;
        this.studentName = studentName;
        this.studentGPA = studentGPA;
    }
}
// Exercise 2: Sample Code
class Program
{
    static void Main(string[] args)
    {   // 2.1 create 8 food objects
        Food food1 = new Food(foodName:"Juice", foodPrice:3.49, foodType:"Drink");
        Food food2 = new Food(foodName:"Orange", foodPrice:0.99, foodType:"Fruit");
        Food food3 = new Food("Chicken", 8.99, "Meat");
        Food food4 = new Food("Broccoli", 2.49, "Vegetable");
        Food food5 = new Food("Banana", 0.59, "Fruit");
        Food food6 = new Food("Beef", 14.99, "Meat");
        Food food7 = new Food("Carrot", 1.29, "Vegetable");
        Food food8 = new Food("Soda", 2.99, "Drink");
        // 2.2 save food objects in the shopping_list array
        Food[] shopping_list = {food1, food2, food3, food4, food5, food6, food7, food8};

        // 3.2 call TotalPrice() method
        TotalPrice(shopping_list);
        // 4.2 call TotalFruitPrice() method
        TotalFruitPrice(shopping_list);
        // 5.2 call AveragePrice() method
        AveragePrice(shopping_list);        
    }
    
    // 3.1 calculate the total price of all food items in the shopping_list and print the result
    public static void TotalPrice(Food[] shopping_list){
        double totalPrice = 0;
        foreach(Food foodItem in shopping_list){
            totalPrice += foodItem.foodPrice;
        }
        Console.WriteLine($"3. The total price of all food items is: {totalPrice}");
    }

    // 4.1 calculate the total price of all food items categorized as "Fruit" and print the result.
    public static void TotalFruitPrice(Food[] shopping_list){
        double totalFruit = 0;
        foreach(var foodItem in shopping_list){
            if (foodItem.foodType == "Fruit"){
                totalFruit += foodItem.foodPrice;
            }
        }
        Console.WriteLine($"4. The total price of all food items is: {totalFruit}");
    }

    // 5.1 Create a method call AveragePrice(Food[] shopping_list) to calculate the average price of all food items in the shopping_list array.
    public static void AveragePrice(Food[] shopping_list){
        double totalPrice = 0;
        int countFood = 0;
        foreach(var foodItem in shopping_list){
                totalPrice += foodItem.foodPrice;
                countFood++;
        }
        if (countFood > 0){
            double averagePrice = totalPrice/countFood;
            Console.WriteLine($"5. The average price of all food items is: {averagePrice}");
        }
    }
}

// 1. create Food class
class Food{
    public string foodName {get;set;} = string.Empty;
    public double foodPrice {get;set;} = 0;
    public string foodType {get;set;} = string.Empty;
    // constructor
    public Food(string foodName, double foodPrice, string foodType){
        this.foodName = foodName;
        this.foodPrice = foodPrice;
        this.foodType = foodType;
    }
}
