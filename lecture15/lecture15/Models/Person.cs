namespace lecture15.Models;

public class Person
{
    
    protected Person(string name, string lastName, int age )
    {
        Name = name;
        LastName = lastName;
        Age = age;
    }
    
    
    public string Name { get; set; }
    public string LastName { get; set; }

    private int _age;

    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 16 || value > 120)
            {
                throw new Exception("Age is not valid, must be between 16 and 120");
            }
            
            _age = value;
        }
    }
    
}