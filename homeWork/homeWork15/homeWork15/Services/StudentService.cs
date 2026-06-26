using homeWork15.Models;

namespace homeWork15.Services;

public class StudentService
{
    private StudentManager _manager;

    public StudentService(StudentManager manager)
    {
        _manager = manager;
    }
    
    // add student
    public void AddStudent()
    {
        Console.WriteLine("Enter student name: ");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Student name cannot be empty!");
            return;
        }

        if (_manager.StudentScores.ContainsKey(name))
        {
            Console.WriteLine("Student already exists!");
            return;
        }

        Console.WriteLine("Enter student score: ");

        if (!int.TryParse(Console.ReadLine(), out int score))
        {
            Console.WriteLine("Score must be a number!");
            return;
        }

        if (score < 0 || score > 100)
        {
            Console.WriteLine("Score must be between 0 and 100");
            return;
        }
        
        _manager.StudentNames.Add(name);
        _manager.StudentScores.Add(name, score);

        Console.WriteLine("Student added successfully!");
    }
    
    
    // find student
    public void FindStudent()
    {
        Console.WriteLine("Enter student name: ");
        string name = Console.ReadLine();
        
        if (_manager.StudentScores.ContainsKey(name))
        {
            Console.WriteLine($"Student {name} has score {_manager.StudentScores[name]}");
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
    }
    
    // score update
    public void UpdateScore()
    {
        Console.WriteLine("Enter student name: ");
        string name = Console.ReadLine();

        if (!_manager.StudentScores.ContainsKey(name))
        {
            Console.WriteLine("Student not found: ");
            return;
        }

        Console.WriteLine("Enter new score: ");

        if (!int.TryParse(Console.ReadLine(), out int score))
        {
            Console.WriteLine("Score must be a number. ");
            return;
        }

        if (score < 0 || score > 100)
        {
            Console.WriteLine("Score must be between 0 and 100. ");
            return;
        }
        
        _manager.StudentScores[name] = score;
        Console.WriteLine("Score updated successfully!");
    }
    
    // show all student
    public void ShowAllStudents()
    {
        if (_manager.StudentNames.Count == 0)
        {
            Console.WriteLine("No students found!");
            return;
        }

        Console.WriteLine("\n===== STUDENTS =====");

        foreach (string name in _manager.StudentNames)
        {
            Console.WriteLine($"{name} - {_manager.StudentScores[name]}");
        }
    }
}