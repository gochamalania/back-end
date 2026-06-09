namespace homeWork10Task2;

public class President : Worker
{
    public President (string name, string lastName, decimal salary, int age) : base(name, lastName, salary, age) { }
    
    public override void Print()
    {
        Console.WriteLine($"President {Name} {LastName}, Age: {Age}, Salary: {Salary}");
    }
}