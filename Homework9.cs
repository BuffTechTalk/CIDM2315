using System;
using System.Collections.Generic;
using System.Linq;
namespace Homework9;

class Program
{
    static void Main(string[] args)
    //setting up the dictionary for student names and gpa's
    {
        var gradebook = new Dictionary<string, double>
        {
        
        {"Alice", 4.0},
        {"Bob", 3.6},
        {"Cathy", 2.5},
        {"David", 1.8},
        };
        gradebook.Add("Tom", 3.3);

        List<Student> students = new List<Student>
        {
        
        //creating each student to a list with id's and name
        new Student(111, "Alice"),
        new Student(222, "Bob"),
        new Student(333, "Cathy"),
        new Student(444, "David"),
        new Student(555, "Tom")
        };
        
        //method to average out all gpa's from students
        double average = gradebook.Values.Average();
        Console.WriteLine($"The average GPA of all students is: {average}\n");
        
        //setting up properties for printing out results
        var aboveAverage = students.Join(gradebook, s => s.StudentName, g => g.Key, (s, g) => new {s.StudentID, s.StudentName, GPA = g.Value}).Where(item => item.GPA > average);

            //taking gpa's from students and printing out result that's above average
            Console.WriteLine($"The students whose GPA is above average are:");
            foreach(var student in aboveAverage)
        {
            Console.WriteLine($"Student ID: {student.StudentID}, Student Name: {student.StudentName}");
        }
    }
}
//creating student class and it's properties with public and private settings
class Student
{
    public int StudentID {get; private set;}
    public string StudentName {get; private set;}
    public Student(int id, string name)
    {
        StudentID = id;
        StudentName = name;
    }
    //method used to print out results on above average student name and id
    public void PrintInfo() =>
    
        Console.WriteLine($"Student ID: {StudentID}, Student Name: {StudentName}");
}
