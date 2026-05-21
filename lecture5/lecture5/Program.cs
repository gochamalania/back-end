namespace lecture5;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        #region homeWork

        // Console.WriteLine("Enter number: ");
        // bool validNum = byte.TryParse(Console.ReadLine(), out byte num);
        //
        // while (!validNum)
        // {
        //     Console.WriteLine("Enter again!");
        //     validNum = byte.TryParse(Console.ReadLine(), out num);
        // }
        //
        // for (int i = 1; i <= num; i++)
        // {
        //     for (int j = 1; j <= num - i; j++)
        //     {
        //         Console.Write(" ");
        //     }
        //     for (int k = 1; k <= i; k++)
        //     {
        //         Console.Write("* ");
        //     }
        //
        //     Console.WriteLine();
        // }
        
        // Console.Write ("Enter number: ");
        // bool validNum = int.TryParse(Console.ReadLine(), out int num);
        //
        // int sum = 0;
        //
        // if (validNum)
        // {
        //     for (int i = 0; i < num; i+=2)
        //     {
        //         sum += i;
        //     }
        // }
        //
        // Console.WriteLine(sum);
        
        
        // Random random = new Random();
        //
        // int randomNumber = random.Next(1, 10);
        // Console.WriteLine("randomNumber: " + randomNumber);
        // Console.WriteLine("Enter Number: ");
        //
        // bool validNum = int.TryParse(Console.ReadLine(), out int userNum);
        //
        // while (!validNum || randomNumber != userNum)
        // {
        //     Console.WriteLine("Wrong number: ");
        //     validNum = int.TryParse(Console.ReadLine(), out userNum);
        // }
        //
        // Console.WriteLine("You win");

        #endregion
        
        // შექმენით მინი ATM აპლიკაცია
        // decimal balance = 1000;
        // მანამ მომხმარებელი არ შეიყვანს კონსოლში 4-ს მანამდე მუდმივად გამოვიდეს სარჩევი შემდეგი ოფშენებით.
        // 1 - Check Balance
        // 2 - Deposit Money
        // 3 - Withdraw Money
        // 4 – Exit
        //
        // 1-ის  არჩევის შემთხვევაში კონსოლში გამოიტანეთ ბალანსი.
        // 2 -ის ან 3-ის არჩევის შემთხვევაში მოსთხოვეთ შეიყვანოს ჩასარიცხი ან გამოსატანი თანხის მოცულობა.
        //     ყურადღება მიაქციეთ ვალიდაციებს.

        // decimal balance = 1000m;
        //
        // while (true)
        // {
        //     Console.WriteLine("\n===== ATM MENU =====");
        //     Console.WriteLine("1 - Check Balance");
        //     Console.WriteLine("2 - Deposit Money");
        //     Console.WriteLine("3 - Withdraw Money");
        //     Console.WriteLine("4 – Exit");
        //
        //     Console.WriteLine("Choose Option: ");
        //     
        //     bool validChoice = int.TryParse(Console.ReadLine(), out int choice);
        //
        //     if (!validChoice)
        //     {
        //         Console.WriteLine("Please enter a valid number!");
        //         continue;
        //     }
        //
        //     switch (choice)
        //     {
        //         case 1:
        //             Console.WriteLine($"Your balance is: {balance} GEL");
        //             break;
        //         
        //         case 2:
        //             Console.WriteLine("Enter deposit amount: ");
        //             bool validDeposit =  decimal.TryParse(Console.ReadLine(), out decimal depositAmount);
        //
        //             if (validDeposit && depositAmount > 0)
        //             {
        //                 balance += depositAmount;
        //                 Console.WriteLine($"Successfully deposited {depositAmount} GEL");
        //             }
        //             else
        //             {
        //                 Console.WriteLine("Invalid deposit amount!");
        //             }
        //             break;
        //
        //         case 3:
        //             Console.WriteLine("Enter withdraw amount: ");
        //             bool validWithdraw = decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount);
        //
        //             if (!validWithdraw || withdrawAmount <= 0)
        //             {
        //                 Console.WriteLine("Invalid withdraw amount!");
        //             }
        //             else if (withdrawAmount > balance)
        //             {
        //                 Console.WriteLine("Insufficient balance!");
        //             }
        //             else
        //             {
        //                 balance -=  withdrawAmount;
        //                 Console.WriteLine($"Successfully Withdrawn {withdrawAmount} GEL");
        //             }
        //             break;
        //         
        //         case 4:
        //             Console.WriteLine("Exit");
        //             return;
        //         
        //         default:
        //             Console.WriteLine("Please choose between 1 and 4!");
        //             break;
        //         
        //     }
        // }
        
        
        
        
        
        // array
        // int[] points = [10, 20, 25, 77, 80, 100];
        //
        // points[0] = 200;
        // points[5] = 295;
        // Console.WriteLine(points.Length);
        // Console.WriteLine(points[1]);
        // Console.WriteLine(points[points.Length - 1]);

        // for (int i = 0; i < points.Length; i++)
        // {
        //     Console.WriteLine(points[i]);
        // }

        // foreach (var point in points)
        // {
        //     Console.WriteLine(point);
        // }
        
        
    }
}