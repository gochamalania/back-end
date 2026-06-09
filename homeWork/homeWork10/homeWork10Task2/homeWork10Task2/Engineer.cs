namespace homeWork10Task2;

public class Engineer : Worker
{
    public Engineer(string name, string lastName, decimal salary, int age ) : base(name, lastName, salary, age) { }
    
    public override void Print()
    {
        Console.WriteLine($"Engineer {Name} {LastName} Age: {Age} Salary: {Salary} ");
    }
}