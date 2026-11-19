using System;
namespace OOP_HT4;
class Employee
{
    public string Name {get; set;}
    public string Department {get; set;}

    public Employee(string name, string department)
    {
        Name = name;
        Department = department;
    }

    public Employee()
    {
        Name = "";
        Department = "";
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{ Name},{Department}");
    }
    
}
class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public Developer(string name, string department, string programmingLanguage)
        : base(name, department)
    {
        ProgrammingLanguage = programmingLanguage;
    }
}

class Designer : Employee
{
    public string DesignTool { get; set; }

    public Designer(string name, string department, string designTool)
        : base(name, department)
    {
        DesignTool = designTool;
    }
}
