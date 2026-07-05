using lecture15.Enums;
using lecture15.Interfaces;

namespace lecture15.Models;

public class Student : Person, IPrintable
{
    
    
    public Student(string name, string lastName, int age, string email, string phone, double gpa, Faculty faculty) : base(name, lastName, age)
    {
        Email = email;
        Phone = phone;
        GPA = gpa;
        Faculty = faculty;
    }

    private string Email { get; set; }
    private string Phone { get; set; }
    public double GPA { get; set; }
    
    public Faculty Faculty { get; set; }

    public void Print()
    {
        Console.WriteLine(ToString());
    }
    
    public override string ToString()
    {
        return $"{Name} {LastName} {Age} {Email} {Phone} {GPA} {Faculty}";
    }
}