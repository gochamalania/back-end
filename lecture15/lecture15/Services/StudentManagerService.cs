using lecture15.Enums;
using lecture15.Helpers;
using lecture15.Models;

namespace lecture15.Services;

public class StudentManagerService
{
    public StudentManagerService()
    {
        FillData();
    }
    
    public Student[] students = new Student[0];

    private void FillData()
    {
        ArrayHelper.Add(ref students, new Student
            (
            "John", "Doe", 20, "johndoe@email.com", "500123456", 1.8, Faculty.Design
            )
        );
        
        ArrayHelper.Add(ref students, new Student
            (
                "Jane", "Smith", 22, "janesmith@email.com", "511123456", 2.0, Faculty.IT
            )
        );
        
        ArrayHelper.Add(ref students, new Student
            (
                "John", "Jolly", 25, "john@email.com", "511123458", 3.99, Faculty.Business
            )
        );
    }
    
    public void PrintAllStudents()
    {
        foreach (var student in students)
        {
            student.Print();
        }
    }
    
}