namespace lecture9;

internal class Student : Human
{
    // public string Name { get; set; }
    // public string LastName { get; set; }
    // public int Age { get; set; }
    
    public byte Grade { get; set; }
    public float GPA { get; set; }
    public bool IsActiveStudent { get; set; }
    
    
    public string[] Subjects { get; set; }
    
    Lesson[] Lessons { get; set; }
    
    
}