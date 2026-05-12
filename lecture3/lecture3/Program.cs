using System.Globalization;
using System.Text;

namespace lecture3;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        
        Console.OutputEncoding = Encoding.UTF8;
        //     
        //     
        // Console.WriteLine("შეიყვანე ასაკი: ");//
        // byte age;
        // bool validAge = byte.TryParse(Console.ReadLine(), out age);//
        // Console.WriteLine(validAge && age >=18 
        //     ? "you can vote" 
        //     : "you can not vote");




        // Console.WriteLine("enter first number: ");
        //
        // int firstNum;
        // bool firstValid = int.TryParse(Console.ReadLine(), out firstNum);
        //
        // int secondNum;
        // bool secondValid = int.TryParse(Console.ReadLine(), out secondNum);
        //
        // int thirdNum;
        // bool thirdValid = int.TryParse(Console.ReadLine(), out thirdNum);
        //
        // int max = firstNum;
        //
        // max = max < secondNum && secondValid ? secondNum : max;
        //
        // max = max < thirdNum && thirdValid ? thirdNum : max;
        //
        // Console.WriteLine(max);



        // Console.WriteLine("enter first number");
        // int firstNum;
        // bool validFirst = int.TryParse(Console.ReadLine(), out firstNum);
        //
        // Console.WriteLine("enter second number");
        // int secondNum;
        // bool validSecond = int.TryParse(Console.ReadLine(), out secondNum);
        //
        // string result = validFirst && validSecond ? (firstNum == secondNum ? $"{(firstNum + secondNum) *3}" : $"{firstNum + secondNum}") : "numbers are not valid";






        // if (5 > 3)
        // {
        //     Console.WriteLine("true");
        // }


        string userName = "user 123";
        string password = "password123";
        string passCode = "123456";

        Console.Write("enter your name: ");
        string userNameInput = Console.ReadLine();
        
        Console.Write("enter your password: ");
        string passwordInput = Console.ReadLine();

        Console.WriteLine("enter passcode");
        string passCodeInput = Console.ReadLine();

        if (userName == userNameInput && (password == passwordInput || passCode == passCodeInput))
        {
            Console.WriteLine("welcome");
        }
        else
        {
            Console.WriteLine("Wrong username or password");
        }



    }
    
    
    
}