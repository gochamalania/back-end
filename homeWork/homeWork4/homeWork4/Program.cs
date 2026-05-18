namespace homeWork4;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        #region task1
        
        // გააკეთე კონსოლიდან შემოყვანილი რიცხვის გამრავლების ტაბულის ერთი ბლოკი. (ათის ნამრავლის
        // ჩათვლით) 
        // შესაყვანი სატესტო მონაცემი: 13
        // მოსალოდნელი შედეგი: 
        // 13 * 1 = 13
        // 13 * 2 = 26
        //     .........
        // 13 * 10 = 130

        // Console.Write("Enter number: ");
        //
        // if (int.TryParse(Console.ReadLine(), out int number))
        // {
        //     for (int i = 1; i <= 10; i++)
        //     {
        //         Console.WriteLine($"{number} * {i} = {number * i}");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Enter a valid number");
        // }
        
        #endregion
        
        #region task2
        // დაწერეთ პროგრამა რომელიც გამოიტანს კონსოლში ფიფქებით შედგენილ პირამიდის ფორმას. მაგალითად 
        //     ციფრი 4–ის შეყვანისას კონსოლში გამოვა შემდეგი სახის პირამიდა: 
        //     *
        //    * *
        //   * * *
        //  * * * *
        
        // Console.Write("Enter a number: ");
        //
        // if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        // {
        //     for (int i = 1; i <= n; i++)
        //     {
        //         for (int j = 1; j <= n - i; j++)
        //         {
        //             Console.Write(" ");
        //         }
        //
        //         for (int k = 1; k <= i; k++)
        //         {
        //             Console.Write("* ");
        //         }
        //
        //         Console.WriteLine();
        //         
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Please enter a valid number!");
        // }
        
        #endregion
        
        #region task3
        // დავალება 3 
        // დაწერეთ პროგრამა რომელიც კონსოლიდან წაკითხულ რიცხვამდე დააჯამებს ყველა ლუწ რიცხვს და პასუხი 
        // გამოიტანეთ კონსოლში
        
        // Console.Write("enter a positive number: ");
        //
        // if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        // {
        //     int sum = 0;
        //
        //     for (int i = 2; i <= n; i += 2)
        //     {
        //         sum += i;
        //     }
        //
        //     Console.WriteLine($"The sum of even numbers from 1 to {n} is: {sum}");
        // }
        // else
        // {
        //     Console.WriteLine("enter a positive number");
        // }

        #endregion
        
        #region task4
        // დაწერეთ პროგრამა რომელიც აირჩევს რენდომულ რიცხვს.
        //     მომხმარებელმა შემოიყვანოს კონსოლიდან რიცხვი მანამ არ გამოიცნობს არჩეულ რენდომულ რიცხვს
        
        // Random random =  new Random();
        //
        // int secretNumber = random.Next(1, 101);
        //
        // Console.WriteLine("Guess the number between 1 and 100!");
        //
        // int guess;
        //
        // while (true)
        // {
        //     Console.Write("Enter number: ");
        //
        //     if (!int.TryParse(Console.ReadLine(), out guess))
        //     {
        //         Console.WriteLine("You entered an incorrect number!");
        //         continue;
        //     }
        //
        //     if (guess < 1 || guess > 100)
        //     {
        //         Console.WriteLine("Number must be between 1 and 100!");
        //         continue;
        //     }
        //
        //     if (guess > secretNumber)
        //     {
        //         Console.WriteLine("Number is too high!");
        //     }
        //
        //     else if (guess < secretNumber)
        //     {
        //         Console.WriteLine("Number is too low!");
        //     }
        //
        //     else
        //     {
        //         Console.WriteLine("Correct! You guessed it!");
        //         break;
        //     }
        //     
        // }

        #endregion

    }
}