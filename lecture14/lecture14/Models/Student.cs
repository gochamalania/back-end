namespace lecture14;

public class Student
{
    
    public Remark<int> Grade { get; set; }
    public Remark<string> Comment { get; set; }
    public Remark<bool> Passed { get; set; }
    
    
    // public Grade Grade { get; set; }
    // public Comment Comment { get; set; }
    // public PassedExam PassedExam { get; set; }
    
    // public void Print<T>(T param)
    // {
    //     Console.WriteLine($"Hello, your {typeof(T).Name} is {param}");
    // }
    
}


public class Remark <T> //where T : struct
{
    public RemarkType Type { get; set; }
    public T Value { get; set; }
    
    public override string ToString()
    {
        return $"{Type} {Value}";
    }
    
    public void Print()
    {
        Console.WriteLine($"Hello, your {Type} is {Value}");
    }
}


// public class Remark <T>
// {
//     public RemarkType Type { get; set; }
//     public T Value { get; set; }
//     
//     public override string ToString()
//     {
//         return $"{Type} {Value}";
//     }
//     
//     public void Print()
//     {
//         Console.WriteLine($"Hello, your {Type} is {Value}");
//     }
// }


public enum RemarkType
{
    Grade,
    Comment,
    Passed
}




// public class Grade
// {
//     public int Value { get; set; }
//
//     public override string ToString()
//     {
//         return $"{Value}";
//     }
//
//     public void Print()
//     {
//         Console.WriteLine(Value);
//     }
// }
//
// public class Comment
// {
//     public string Value { get; set; }
//     
//     public override string ToString()
//     {
//         return $"{Value}";
//     }
//
//     public void Print()
//     {
//         Console.WriteLine(Value);
//     }
// }
//
// public class PassedExam
// {
//     public bool Value { get; set; }
//     
//     public override string ToString()
//     {
//         return $"{Value}";
//     }
//     
//     public void Print()
//     {
//         Console.WriteLine(Value);
//     }
// }