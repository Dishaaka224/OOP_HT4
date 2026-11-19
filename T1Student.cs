using System;
namespace OOP_HT4;

class T1Student

{
    public static void RunTask1()
    {
        Console.WriteLine("Task1 :PERSON VA STUDENT");
        var student = new Student("Ali", "C#");
        student.Introduce();
        Console.WriteLine(student.Course);

        var dev = new Developer("Malika", "IT", "C#");
        var designer = new Designer("Jasur", "Design", "figma");
    }
}



class Person
{
    public string Name {get; set;}
    public Person (string name)
    {
        Name = name;
    } 
    public void Introduce()
    {
        Console.WriteLine($"Salom, men {Name}.");
    }

}

class Student : Person
{
    public string Course { get; set; }

    public Student(string name, string course) : base(name)
    {
        Course = course;
    }
}