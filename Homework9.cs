using System;
using System.Collections.Generic;
using System.Linq;
namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, double> gradebook = new Dictionary<string, double>()
        {
        
        {"Alice", 4.0},
        {"Bob", 3.6},
        {"Cathy", 2.5},
        {"David", 1.8},
        };
        gradebook.Add("Tom", 3.3);

        Student.studentList.Add(new Student(111, "Alice"));
        Student.studentList.Add(new Student(222, "Bob"));
        Student.studentList.Add(new Student(333, "Cathy"));
        Student.studentList.Add(new Student(444, "David"));
        Student.studentList.Add(new Student(555, "Tom"));

        double average = gradebook.Values.Average();
        Console.WriteLine($"The average GPA of all students is: {average}\n");

        var studentGrades = Student.studentList.Join(gradebook, student => student.GetName(), grade => grade.Key, (student, grade) => new 
        {
            ID = student.GetID(),
            Name = student.GetName(),
            GPA = grade.Value
        }
        );

        Console.WriteLine($"The students whose GPA is above average are:");
        foreach (var item in studentGrades)
        {
            if (item.GPA > average)
            {
                Console.WriteLine($"Student ID: {item.ID}, Student Name: {item.Name}");
            }
        }
    }
}
class Student
{
    public static List<Student> studentList = new List<Student>();
    private int studentID;
    private string studentName;
    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
    }
    public string GetName() => studentName;
    public int GetID() => studentID;
    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
}
