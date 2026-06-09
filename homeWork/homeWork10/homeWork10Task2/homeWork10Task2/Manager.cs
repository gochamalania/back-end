namespace homeWork10Task2;

public class Manager : Worker
{
    public Manager(string name, string lastName, decimal salary, int age) : base(name, lastName, salary, age) { }
    
    public override void Print()
    {
        Console.WriteLine($"Manager {Name} {LastName} Age: {Age} Salary: {Salary} ");
    }
}