namespace lecture9;

internal class Teacher : Employee
{
    // public string Name { get; set; }
    // public string LastName { get; set; }
    // public int Age { get; set; }
    // public decimal Salary { get; set; }
    
    
    public string Subject { get; set; }
    public Lesson[] Lessons { get; set; }


    public decimal GetBonus()
    {
        return Lessons.Length * 100;    
    }
    
    
}