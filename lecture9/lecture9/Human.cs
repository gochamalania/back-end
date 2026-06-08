namespace lecture9;

public class Human
{
    public Human()
    {
    }

    public Human(string name, string lastName, byte age)
    {
        Name = name;
        LastName = lastName;
        Age = age;
    }

    public string Name { get; set; }
    public string LastName { get; set; }
    public byte Age { get; set; }
    
    
    public void PrintInfo() => Console.WriteLine($"{Name} {LastName} {Age}");
    
}