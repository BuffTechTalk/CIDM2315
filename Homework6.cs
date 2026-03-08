namespace Homework6;

class Program
{
    static void Main(string[] args)
    //Q1 Answer
    //creating each professor and student object
    {
       Professor p1 = new Professor("Alice", "Java", 9000);
       Professor p2 = new Professor("Bob", "Math", 8000);
       Student s1 = new Student("Lisa", "Java", 90);
       Student s2 = new Student("Tom", "Math", 80);
       
       //Q2 Answer
       //printing out each objects info
       p1.PrintProfessorInfo();
       p2.PrintProfessorInfo();
       s1.PrintStudentInfo();
       s2.PrintStudentInfo();
       
       //Q2 Answer
       //logic used to find difference in professor salaries and displaying result
       double salaryDiff = p1.Salary - p2.Salary;
       Console.WriteLine($"The salary difference between {p1.profName} and {p2.profName} is: {salaryDiff}");
       
       //Q2 Answer
       //logic used to find total sum of student grades and displaying result
       double gradeSum = s1.StudentGrade + s2.StudentGrade;
       Console.WriteLine($"The total grade of {s1.studentName} and {s2.studentName} is: {gradeSum}");

    }
}
class Professor
//Code for Professor class
//variables used for Professor class set up
{
    public string profName;
    public string classTeach;
    private double salary;
    //allowing a public property to be viewed from a private field
    public double Salary
    {
        get {return salary;}
        set {salary = value;}
    }
    //setting up Professor parameters
    public Professor(string name, string subject, double Salary)
    {
        profName = name;
        classTeach = subject;
        salary = Salary;
    }
    //Method used to print each Professor info
    public void PrintProfessorInfo()
    {
        Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {salary}");
    }
}
class Student
//Code for Student class
//variables used for Student class setup
{
    public string studentName;
    public string classEnroll;
    private double studentGrade;
    //allowing a public property to be viewed from a private field
    public double StudentGrade
    {
        get {return studentGrade;}
        set {studentGrade = value;}
    }
    //setting up Student parameters
    public Student(string name, string course, double StudentGrade)
    {
        studentName = name;
        classEnroll = course;
        studentGrade = StudentGrade;
    }
    //Method used to print each Student info
    public void PrintStudentInfo()
    {
        Console.WriteLine($"Student {studentName} is enrolled in {classEnroll}, and the grade is: {studentGrade}");
    }
}
