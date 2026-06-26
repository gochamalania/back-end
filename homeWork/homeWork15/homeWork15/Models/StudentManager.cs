namespace homeWork15.Models;

public class StudentManager
{
    public List<string> StudentNames { get; set; }
    
    public Dictionary<string, int> StudentScores { get; set; }

    public StudentManager()
    {
        StudentNames = new List<string>();
        StudentScores = new Dictionary<string, int>();
    }
}