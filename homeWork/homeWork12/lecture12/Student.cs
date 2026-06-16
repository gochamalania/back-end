namespace lecture12;

public class Student
{
    // Giorgi,Beridze,25,g.beridze@email.com,599123456,90
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public int Age {get; set;}
    public string Email {get; set;}
    public string Phone {get; set;}
    public int Score {get; set;}


    public Student(string firstName, string lastName, int age, string email, string phone, int score)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Email = email;
        Phone = phone;
        Score = score;
    }

    public void Print()
    {
        Console.WriteLine(FirstName + " " + LastName + ", Age: "  + Age + " " + Email + " " + Phone + ", Score: " + Score);
    }
    
    
    
    // ვიპოვოთ სტუდენტები, რომელსაც დაბალი ქულა აქვს;
    // ასაკით დიდი;
    // ყველა სტუდენტის საშუალო ქულა;
    // დაასორტირეთ სტუდენტების მასივი
}