namespace homeWork6_array2;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        #region Task1

        // შექმენით jagged array სადაც: თითოეულ სტუდენტს
        // აქვს სხვადასხვა რაოდენობის ქულა. იპოვეთ თითოეულის საშუალო ქულა. 

        // int[][] studentScores =
        // {
        //     new int[] {77, 82},
        //     new int[] {75, 80, 99},
        //     new int[] {99, 100, 88, 98},
        // };
        //
        // for (int i = 0; i < studentScores.Length; i++)
        // {
        //     int sum = 0;
        //
        //     for (int j = 0; j < studentScores[i].Length; j++)
        //     {
        //         sum += studentScores[i][j];
        //     }
        //     
        //     double average = (double)sum / studentScores[i].Length;
        //
        //     Console.WriteLine($"Student {i + 1} average score: {average}" );
        // }

        #endregion

        #region Task2
        
        // შექმენით რენდომული 4 ნიშნა პასკოდების არაი (10 წევრი).
        // მომხმარებელს შემოაყვანინეთ კოდი და თუ რომელიმეს დაემთხვა არაიში
        // დაუბეჭდეთ “Correct” თუ არა და “Wrong”. 

        // Random random = new Random();
        //
        // int[] passCodes = new int[10];
        //
        // for (int i = 0; i < passCodes.Length; i++)
        // {
        //     passCodes[i] = random.Next(1000, 10000);
        // }
        //
        // Console.WriteLine("DEBUG - Generated passcodes:");
        // for (int i = 0; i < passCodes.Length; i++)
        // {
        //     Console.Write(passCodes[i] + " ");
        // }
        //
        // Console.WriteLine("Enter 4-digit passcode: ");
        //
        // int userCode;
        //
        // while (!int.TryParse(Console.ReadLine(), out userCode) || userCode < 1000 || userCode > 9999)
        // {
        //     Console.WriteLine("Enter a valid 4-digit code: ");
        // }
        //
        // bool found = false;
        //
        // for (int i = 0; i < passCodes.Length; i++)
        // {
        //     if (passCodes[i] == userCode)
        //     {
        //         found = true;
        //         break;
        //     }
        // }
        //
        // Console.WriteLine(found ? "Correct" : "Wrong");
        //
        #endregion

        #region Task3

        // შექმენით int-ების (მათ შორის ნეგატიური რიცხვებიც) მასივი.
        // იპოვეთ მინიმალური და მაქსიმალური რიცხვები (არ გამოიყენოთ არაის მეთოდები). 

        // int[] numbers = { 3, -5, 10, 0, 35, 67, -9 };
        //
        // int min = numbers[0];
        // int max = numbers[0];
        //
        // for (int i = 1; i < numbers.Length; i++)
        // {
        //     if (numbers[i] < min)
        //     {
        //         min = numbers[i];
        //     }
        //
        //     if (numbers[i] > max)
        //     {
        //         max = numbers[i];
        //     }
        // }
        //
        // Console.WriteLine($"Min: {min}");
        // Console.WriteLine($"Max: {max}");

        #endregion
        
        #region Task4
        
        // შექმენით სტრინგების მასივი და კონსოლში დაბეჭდეთ
        // ყველა ელემენტის ყველა სიმბოლო (არ გამოიყენოთ არაის მეთოდები). 

        // string[] words = { "hello", "world", "error" };
        //
        // for (int i = 0; i < words.Length; i++)
        // {
        //     for (int j = 0; j < words[i].Length; j++)
        //     {
        //         Console.Write(words[i][j] + " ");
        //     }
        //
        //     Console.WriteLine();
        // }

        #endregion
        
        #region Task5
        
        // შექმენით იმეილების მასივი და დაადგინეთ ყველა ელემენტი
        // თუ შეიცავს @ სიმბოლოს. (არ გამოიყენოთ არაის და სტრინგის ჩაშენებული მეთოდები). 

        // string[] emails = { "test@info.com", "hello.world", "user@gmail.com", "mail#mail.com" };
        //
        // for (int i = 0; i < emails.Length; i++)
        // {
        //     bool hasAt = false;
        //
        //     for (int j = 0; j < emails[i].Length; j++)
        //     {
        //         if (emails[i][j] == '@')
        //         {
        //             hasAt = true;
        //             break;
        //         }
        //     }
        //
        //     if (hasAt)
        //     {
        //         Console.WriteLine(emails[i]+ " Valid Email");
        //     }
        //     else
        //     {
        //         Console.WriteLine(emails[i] + " Invalid Email");
        //     }
        // }

        #endregion

    }
}