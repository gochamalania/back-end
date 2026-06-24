namespace homeWork13_project;

public class Student : Person, IPrintable
{
    private string _email;
    private string _phone;
    private double _gpa;

    public string Email
    {
        get { return _email; }
        set
        {
            if (string.IsNullOrEmpty(value) || !value.Contains("@"))
            {
                Console.WriteLine("Email is not valid");
                return;
            }
            _email = value.Trim();
        }
    }

    public string Phone
    {
        get {return _phone; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Phone cannot be empty");
                return;
            }
            _phone = value.Trim();
        }
    }

    public double GPA
    {
        get { return _gpa; }
        set
        {
            if (value < 0 || value > 4)
            {
                Console.WriteLine("GPA cannot be less than 0 or greater than 4");
                return;
            }
            _gpa = value;
        }
    }
    
    public Faculty Faculty { get; set; }

    public Student(
        string name,
        string lastName,
        int age,
        string email,
        string phone,
        double gpa,
        Faculty faculty) : base(name, lastName, age)
    {
        Email = email;
        Phone = phone;
        GPA = gpa;
        Faculty = faculty;
    }

    public void Print()
    {
        Console.WriteLine($"{Name} {LastName} | Age: {Age} | Faculty: {Faculty} | GPA: {GPA}");
    }
    
    // Comparing students by GPA
    public static bool operator > (Student s1, Student s2)
    {
        return s1.GPA > s2.GPA;
    }

    // Operator Overloading
    public static bool operator <(Student s1, Student s2)
    {
        return s1.GPA < s2.GPA;
    }
}