namespace homeWork2;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        

        #region task1

        // დავალება 1:
        // Login სისტემა: პროგრამაში გვაქვს
        // username: admin
        // password: 1234
        // მომხმარებელს შემოჰყავს ორივე მნიშვნელობა
        // თუ სწორია კონსოლში გამოიტანე:
        // Welcome!
        // თუ არა:
        // Access denied

        // string userName = "admin";
        // string password = "1234";
        //
        // Console.WriteLine("Enter user name: ");
        // string userNameInput = Console.ReadLine();
        //
        // Console.WriteLine("Enter password: ");
        // string userPaswordInput = Console.ReadLine();
        //
        // if (userName == userNameInput && password == userPaswordInput)
        // {
        //     Console.WriteLine("Welcome");
        // }
        // else
        // {
        //     Console.WriteLine("Access denied");
        // }

        #endregion

        #region task2

        // Calculator (switch-ით)
        // მომხმარებელი შეიყვანს:
        //     · რიცხვი 1
        //     · ოპერატორი (+ - * /)
        //     · რიცხვი 2
        // კონსოლში გამოიტანე არითმეტიკული ოპერაციის შედეგი. (შემოყვანილი ოპერატორის შესაბამისად)

        // Console.WriteLine("Enter first number: ");
        // double number1 = Convert.ToDouble(Console.ReadLine());
        //
        // Console.WriteLine("Enter operator(+, -, *, /)");
        // string operator1 = Console.ReadLine();
        //
        // Console.WriteLine("Enter second number: ");
        // double number2 = Convert.ToDouble(Console.ReadLine());
        //
        // double result;
        //
        // switch (operator1)
        // {
        //     case "+":
        //         result = number1 + number2;
        //         Console.WriteLine("Result: " + result);
        //         break;
        //     case "-":
        //         result = number1 - number2;
        //         Console.WriteLine("Result: " + result);
        //         break;
        //     case "*":
        //         result = number1 * number2;
        //         Console.WriteLine("Result: " + result);
        //         break;
        //     case "/":
        //         if (number2 != 0)
        //         {
        //             result = number1 / number2;
        //             Console.WriteLine("Result: " + result);
        //         }
        //         else
        //         {
        //             Console.WriteLine("Cannot divide by zero.");
        //         }
        //         break;
        //     default:
        //         Console.WriteLine("Invalid operator.");
        //         break;
        // }


        #endregion
        
        #region task3
        
        // დავალება 3 :
        // მომხმარებელს შეაყვანინე ასაკი:
        // დაადგინე და კონსოლში გამოიტანე:
        //     · ბავშვი (0–12)
        //     · თინეიჯერი (13–19)
        //     · ზრდასრული (20–64)
        //     · პენსიონერი (65+)


        // Console.WriteLine("Enter your age: ");
        //
        // if (byte.TryParse(Console.ReadLine(), out byte age))
        // {
        //     if (age >= 0 && age <= 12)
        //     {
        //         Console.WriteLine("Child");
        //     } 
        //     else if (age >= 13 && age <= 19)
        //     {
        //         Console.WriteLine("Teenager");
        //     }
        //     else if (age >= 20 && age <= 64)
        //     {
        //         Console.WriteLine("Adult");
        //     } 
        //     else if (age >= 65)
        //     {
        //         Console.WriteLine("Pensioner");
        //     }
        //     
        // }
        // else
        // {
        //     Console.WriteLine("Invalid input");
        // }
        
        
        #endregion




    }
}