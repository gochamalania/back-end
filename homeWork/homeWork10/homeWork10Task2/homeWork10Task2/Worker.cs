namespace homeWork10Task2;

public abstract class Worker
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }

    public Worker(string name, string lastName, decimal salary, int age)
    {
        Name = name;
        LastName = lastName;
        Age = age;
        Salary = salary;
    }
    
    public abstract void Print();
}