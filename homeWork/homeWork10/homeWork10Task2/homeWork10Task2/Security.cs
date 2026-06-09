namespace homeWork10Task2;

public class Security : Worker
{
    public Security(string name, string lastName, decimal salary, int age) : base(name, lastName, salary, age) { }
    
    public override void Print()
    {
        Console.WriteLine($"Security: {Name} {LastName} Age: {Age} Salary: {Salary} ");
    }
}