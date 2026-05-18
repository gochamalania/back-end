namespace lecture4;

class Program
{
    static void Main(string[] args)
    {

        #region homeWork
        
        // Console.WriteLine("Hello, World!");

        // Console.WriteLine("Enter first number: ");
        // int num1;
        // bool validNum1  = int.TryParse(Console.ReadLine(), out num1);
        //
        // Console.WriteLine("Enter operator");
        // string opperator = Console.ReadLine();
        //
        // Console.WriteLine("Enter second number: ");
        // int num2;
        // bool validNum2  = int.TryParse(Console.ReadLine(), out num2);
        //
        // if (validNum1 && validNum2)
        // {
        //     switch (opperator)
        //     {
        //         case "+":
        //             Console.WriteLine(num1 + num2);
        //             break;
        //         case "-":
        //             Console.WriteLine(num1 - num2);
        //             break;
        //         case "*":
        //             Console.WriteLine(num1 * num2);
        //             break;
        //         case "/":
        //             if (num2 == 0)
        //             {
        //                 Console.WriteLine("Division by zero impossible");
        //             }
        //
        //             Console.WriteLine((double)num1 / num2);
        //             break;
        //         default:
        //             Console.WriteLine("Invalid operator");
        //             break;
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Invalid input");
        // }
        //
        // Console.ReadKey();


        // int x = int.MaxValue;
        // x++;
        // Console.WriteLine(x + " " + int.MinValue);


        // byte age;
        // bool ageValid = byte.TryParse(Console.ReadLine(), out age);
        //
        // if (ageValid)
        // {
        //     if (age >= 0 && age <= 12)
        //     {
        //         Console.WriteLine("Child");
        //     }
        //     else if (age <= 19)
        //     {
        //         Console.WriteLine("Teenager");
        //     }
        //     else if (age <= 64)
        //     {
        //         Console.WriteLine("Adult");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Pensioner");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("You entered an invalid age");
        // }
        
        
        #endregion


        // Console.WriteLine("Hello World!");

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine("Hello");
        // }

        // for (int i = 0; i < 11; i+=2)
        // {
        //     Console.WriteLine(i);
        // }


        // for (int i = 2; i < 10; i++)
        // {
        //     // Console.WriteLine(i);
        //     int count = 0;
        //     for (int j = 2; j < i; j++)
        //     {
        //         // Console.WriteLine(j);
        //         
        //         if( i % j == 0)
        //         {
        //             count++;
        //         }
        //     }
        //
        //     if (count > 0)
        //     {
        //         Console.WriteLine(i + " " + count);
        //     }
        //     
        //     
        // }


        // Console.WriteLine("Enter your age: ");
        // bool validAge = int.TryParse(Console.ReadLine(), out int age);
        //
        // while (!validAge)
        // {
        //     Console.WriteLine("Try again: ");
        //     validAge = int.TryParse(Console.ReadLine(), out age);
        // }
        //
        // Console.WriteLine($"Your age is {age}");
        // Console.ReadKey();


        // int i = 0;
        // while (i < 10)
        // {
        //     i++;
        //     if (i == 2)
        //     {
        //         continue;
        //     }
        //     // Console.WriteLine(i);
        //
        //     if (i == 5)
        //     {
        //         break;
        //     }
        //     Console.WriteLine(i);
        //     
        // }


        // int x = 5;
        // while (x > 5)
        // {
        //     Console.WriteLine(x);
        //     x++;
        // }


        // int x = 5;
        // do
        // {
        //     Console.WriteLine(x);
        //     x++;
        // } while (x > 5);
        
        Random r =  new Random();

        Console.WriteLine(r.Next(1, 10));
        


    }
    
    
}
