namespace homeWork13_project;

public class StudentService
{
    private Student[] _students;
    private int _count;

    public StudentService(Student[] students, int count)
    {
        _students = students;
        _count = count;
    }
    
    // Show all students
    public void ShowAllStudents()
    {
        for (int i = 0; i < _count; i++)
        {
            _students[i].Print();
        }
    }
    
    // Best Student (Highest GPA)
    public Student GetBestStudent()
    {
        Student best = _students[0];
        
        for (int i = 1; i < _count; i++)
        {
            if (_students[i] > best) //operator overloading
            {
                best = _students[i];
            }
        }
        
        return best;
    }
    
    // average GPA
    public double GetAverageGPA()
    {
        double sum = 0;
        for (int i = 0; i < _count; i++)
        {
            sum += _students[i].GPA;
        }
        return sum / _count;
    }
    
    // Search by LastName
    public void SearchByLastName(string lastName)
    {
        bool found = false;

        for (int i = 0; i < _count; i++)
        {
            if (_students[i].LastName.ToLower().Contains(lastName.ToLower().Trim()))
            {
                _students[i].Print();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Student not found");
        }
    }
    
    // GPA sorting (Bubble Sort - descending)
    public void SortByGPA()
    {
        for (int i = 0; i < _count - 1; i++)
        {
            for (int j = 0; j < _count - i - 1; j++)
            {
                if (_students[j].GPA < _students[j + 1].GPA)
                {
                    Student temp = _students[j];
                    _students[j] = _students[j + 1];
                    _students[j + 1] = temp;
                }
            }
        }
    }
    
    // Add new student
    public void AddStudent(Student student)
    {
        if (_count >= _students.Length)
        {
            Console.WriteLine("Students array is full");
            return;
        }
        
        _students[_count] = student;
        _count++;

        Console.WriteLine("Student added successfully");
    }
    
    // delete student (via email)
    public void DeleteStudent(string email)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_students[i].Email == email)
            {
                for (int j = i; j < _count - 1; j++)
                {
                    _students[j] = _students[j + 1];
                }
                
                _count--;
                Console.WriteLine("Student deleted successfully");
                return;
            }
        }

        Console.WriteLine("Student not found");
    }
    
    
    
    
    
}