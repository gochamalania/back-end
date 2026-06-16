using System.Globalization;

namespace lecture12;

class Program
{
    static void Main(string[] args)
    {

        #region homeWork

        // ArrayClass ac = new ArrayClass([50,17, 50, 60, 30, 15]);
        //
        // ac.ShowEven();
        // ac.ShowOdd();
        //
        //
        // Console.WriteLine(ac.CountDinstinct());
        // Console.WriteLine(ac.EqualToValue(50));

        #endregion

        #region ClassWork

        // Money money = new Money();
        // money.Val = 50;
        // money.Currency = "EUR";
        //
        // Money money2 = new Money();
        // money2.Val = 40;
        // money2.Currency = "EUR";
        //
        // Console.WriteLine(money + money2);
        // Console.WriteLine(money - money2);
        // Console.WriteLine(money * money2);
        // Console.WriteLine(money / money2);
        //
        // Console.WriteLine(money++);
        // Console.WriteLine(money--);
        //
        // Console.WriteLine(money == money2);
        // Console.WriteLine(money != money2);
        // Console.WriteLine(money > money2);

        #endregion




        string path = @"../../../data.txt";
        
        string[] lines = File.ReadAllLines(path);
        
        Student[] students = new Student[lines.Length];

        int index = 0;

        for (int i = 0; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');

            int age = int.Parse(parts[2]);
            int score = int.Parse(parts[5]);
            
            Student student = new Student(
                parts[0],
                parts[1],
                age,
                parts[3], 
                parts[4], 
                score
            );
            students[index] = student;
            index++;
        }

        Console.WriteLine("=====All Students=====");
        for (int i = 0; i < students.Length; i++)
        {
            students[i].Print();
        }
        
        StudentService service = new StudentService();


        Console.WriteLine("\n==== Lowest Score ====");
        Student low = service.GetLowestScore(students);
        low.Print();


        Console.WriteLine("\n==== Oldest Student ====");
        Student old = service.GetOldest(students);
        old.Print();


        Console.WriteLine("\n==== Average Score ====");
        double avg = service.GetAverageScore(students);
        Console.WriteLine(avg);


        Console.WriteLine("\n==== Sort By Score ====");
        service.SortByScore(students);

        for (int i = 0; i < students.Length; i++)
        {
            students[i].Print();
        }


        Console.WriteLine("\n==== Sort By Age ====");
        service.SortByAge(students);

        for (int i = 0; i < students.Length; i++)
        {
            students[i].Print();
        }

    }
}