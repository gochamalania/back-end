namespace homeWork13_project;

public abstract class Person
{
    private string _name;
    private string _lastName;
    private int _age;

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Name cannot be empty");
                return;
            }
            _name = value.Trim();
        }
    }

    public string LastName
    {
        get { return _lastName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Last name cannot be empty");
                return;
            }
            _lastName = value.Trim();
        }
    }

    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 16)
            {
                Console.WriteLine("Age cannot be less than 16");
                return;
            }
            _age = value;
        }
    }
    
    protected Person (string name, string lastName, int age)
    {
        Name = name;
        LastName = lastName;
        Age = age;
    }
    
}