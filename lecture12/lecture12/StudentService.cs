namespace lecture12;

public class StudentService
{
    // Lowest score
    public Student GetLowestScore(Student[] students)
    {
        Student min = students[0];
        foreach (Student student in students)
        {
            if (student.Score < min.Score)
            {
                min = student;
            }
        }
        return min;
    }
    
 
    // The oldest
    public Student GetOldest(Student[] students)
    {
        Student oldest = students[0];
        foreach (Student student in students)
        {
            if (student.Age > oldest.Age)
            {
                oldest = student;
            }
        }
        return oldest;
    }
    
    
    // Average score
    public double GetAverageScore(Student[] students)
    {
        int sum = 0;
        foreach (Student student in students)
        {
            sum += student.Score;
        }
        return (double)sum / students.Length;
    }
    
    
    // Sort by score
    public void SortByScore(Student[] students)
    {
        for (int i = 0; i < students.Length; i++)
        {
            for (int j = 1; j < students.Length; j++)
            {
                if (students[i].Score < students[j].Score)
                {
                    Student temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }
    }
    
    
    // Sort by age   
    public void SortByAge(Student[] students)
    {
        for (int i = 0; i < students.Length; i++)
        {
            for (int j = 1; j < students.Length; j++)
            {
                if (students[i].Age > students[j].Age)
                {
                    Student temp = students[i];
                    students[i] = students[j];
                    students[j] = temp;
                }
            }
        }
    }
}