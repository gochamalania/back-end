namespace lecture13;

public class Student : IComparable
{
    private int _age;
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age {
        get => _age;

        set
        {
            if (value < 0)
            {
                // throw new InvalidAgeException();
                throw new InvalidAgeException("Age cannot be negative");
                
                // throw new Exception("Age cannot be negative.");
            }
            _age = value;
        }
    }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int Point { get; set; }


    public int CompareTo(object? other)
    {
        return this.Point.CompareTo((other as Student).Point);
    }
    
    public override string ToString()
    {
        return $"{FirstName} {LastName} {Age} {Point}";
    }
    
    public static bool operator < (Student s1, Student s2) => s1.Age < s2.Age;
    public static bool operator >(Student s1, Student s2) => s1.Age > s2.Age;
    // public static int operator +(int val, Student s1) => val + s1.Point;

    public static int operator +(Student s1, Student s2) => s1.Point + s2.Point;

    public static implicit operator int(Student s1) => s1.Point;
    // public static implicit operator string (Student s1) => s1.FirstName;
    public static explicit operator Student(int s1) => new Student { Point = s1 };



}