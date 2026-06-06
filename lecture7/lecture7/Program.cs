namespace lecture7;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        #region homeWork

        // int[][] points =
        // [
        //     [85, 90, 78],
        //     [92, 88, 95],
        //     [76, 82, 89]
        // ];
        //
        // int index = 1;
        //
        // foreach (var student in points)
        // {
        //     int sumRow = 0;
        //
        //     foreach (var point in student)
        //     {
        //         sumRow += point;
        //     }
        //
        //     Console.WriteLine("student " + index + " average: " + sumRow / student.Length);
        //     index++;
        // }


        // string[] codes = new string[10];
        //
        // Random r = new Random();
        //
        // for (int i = 0; i < codes.Length; i++)
        // {
        //     codes[i] = r.Next(1000, 9999).ToString();
        // }
        //
        // Console.WriteLine("Enter Code: ");
        // string input = Console.ReadLine();
        //
        // bool isCorrect = false;
        //
        // foreach (var code in codes)
        // {
        //     if (code == input)
        //     {
        //         isCorrect = true;
        //         break;
        //     }
        // }
        //
        // Console.WriteLine(isCorrect ?  "Correct" : "Incorrect");
        

        // int[] numbers = [20, 60, -400, 50, -60, 150];
        // int min = numbers[0];
        // int max = numbers[0];
        //
        // foreach (var num in numbers)
        // {
        //     if (num < min)
        //     {
        //         min = num;
        //     }
        //
        //     if (num > max)
        //     {
        //         max = num;
        //     }
        //     
        // }
        //
        // Console.WriteLine($"min={min} max={max}");


        // int x = 5;
        // int y = 10;
        //
        // int temp = x;
        // x = y;
        // y = temp;
        
        // int[] numbers = [20, 60, -400, 50, -60, 150];
        //
        // foreach (var item in numbers)
        // {
        //     for (int i = 0; i < numbers.Length - 1; i++)
        //     {
        //         if (numbers[i] > numbers[i + 1])
        //         {
        //             int temp = numbers[i];
        //             numbers[i] = numbers[i + 1];
        //             numbers[i + 1] = temp;
        //         }
        //     }
        // }
        //
        // Console.WriteLine(numbers[0] + numbers[numbers.Length - 1]);



        // string[] texts = ["Hello World", "Goodbye", "Greetings"];
        //
        // foreach (string text in texts)
        // {
        //     foreach (var symbol in text)
        //     {
        //         Console.WriteLine(symbol );
        //     }
        // }



        // string[] emails = ["info@info.ge", "gmail@gmail.com"];
        // int count = 0;
        //
        // for (int i = 0; i < emails.Length; i++)
        // {
        //     for (int j = 0; j < emails[i].Length; j++)
        //     {
        //         if (emails[i][j] == '@')
        //         {
        //             count++;
        //         }
        //     }
        // }
        //
        // Console.WriteLine(count == emails.Length ? "Correct" : "Incorrect");


        #endregion

        #region MyRegion
        
        // void return  ორი ტიპის ფუნქციაა
        
        
        // void რაღაცას გააკეთებს, უკან არ აბრუნებს არაფერს. არაფრის გამომტანი არ არის.

        // Console.WriteLine( "Hello World!"); void ფუნქციაა //void

        // Console.ReadLine(); არა void ფუნქცია. აბრუნებს მნიშვნელობას რაც მომხმარებელს შემოაქვს. //return


        // void Test()
        // {
        //     for (int i = 0; i < 10; i++)
        //     {
        //         Console.WriteLine("Hello World!");
        //     }
        //     // Test();
        // }
        //
        // Test();
        
        // void SayHello(string greeting)
        // {
        //     Console.WriteLine(greeting);
        // }
        // SayHello("hello");
        // SayHello("world");
        #endregion
        
        // Random r = new Random();
        // r.Next();
        //
        // Test();
        //
        // Console.WriteLine();
        //
        // int sum = Sum(1, 2);
        //
        // Console.WriteLine(sum);
        
        
        Person persona = new Person();
        persona.Name = "John";
        persona.Age = 20;
        // Console.WriteLine(persona.Name);
        // Console.WriteLine(persona.Age);

        User user1 = new User ( "joe","joe@info.ge");
        Console.WriteLine(user1.UserName);
        Console.WriteLine(user1.Email);
        user1.ShowInfo();


    }

    #region Methods

    // public static void Test()
    // {
    //     Console.WriteLine("test");
    // }
    //
    //
    // public static string test2()
    // {
    //     return "test2";
    // }
    //
    // public static int Sum(int a, int b)
    // {
    //     return a + b;
    // }
    
    #endregion
    
}

// ctor
public class Person()
{
    public string Name; //feald
    public int Age;
    
}