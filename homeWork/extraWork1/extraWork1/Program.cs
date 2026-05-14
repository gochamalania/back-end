using System.Globalization;

namespace extraWork1;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        #region task1
        // შექმენი პროგრამა, რომელიც:
        // ჩაიწერს მომხმარებლის სახელს
        //     ჩაიწერს გვარს
        //     გამოიტანს მისალმებას ინტერპოლაციით  

        // Console.WriteLine("Enter your name: ");
        // string firstName = Console.ReadLine();
        //
        // Console.WriteLine("Enter your Last name: ");
        // string lastName = Console.ReadLine();
        //
        // Console.WriteLine($"Hello {firstName} {lastName}");
        #endregion
        
        #region task2
        // შექმენი პროგრამა, რომელიც კითხულობს ტემპერატურას და გამოიტანს: 
        //
        // 30-ზე მეტი → "ცხელა" (წითელი ფონი) 
        //
        // 15-დან 30-მდე → "თბილია" (ყვითელი ფონი) 
        //
        // 0-დან 15-მდე → "გრილია" (ცისფერი ფონი) 
        //
        // 0-ზე ნაკლები → "ცივა" (ლურჯი ფონი) 

        // Console.WriteLine("Enter Temperature: ");
        //
        // if (int.TryParse(Console.ReadLine(), out int temperature))
        // {
        //     if (temperature > 30)
        //     {
        //         Console.BackgroundColor = ConsoleColor.Red;
        //         Console.WriteLine("Hot");
        //     }
        //     else if (temperature >= 15 && temperature <= 30)
        //     {
        //         Console.BackgroundColor = ConsoleColor.Yellow;
        //         Console.WriteLine("Warm");
        //     }
        //     else if (temperature >= 0 && temperature <= 15)
        //     {
        //         Console.BackgroundColor = ConsoleColor.Cyan;
        //         Console.WriteLine("Cold");
        //     }
        //     else
        //     {
        //         Console.BackgroundColor = ConsoleColor.Blue;
        //         Console.WriteLine("frozen");
        //     }
        //     Console.ResetColor();
        // }
        // else
        // {
        //     Console.WriteLine("Enter a valid temperature: ");
        // }
        
        #endregion

        #region task3
        // შექმენი პროგრამა, რომელიც კითხულობს ქულას (0-100) და გამოიტანს ნიშანს: 
        // 90-100 → A (ფანტასტიკურია) 
        // 80-89 → B (კარგია) 
        // 70-79 → C (საშუალოდ) 
        // 60-69 → D (ცუდად) 
        // 60-ზე ნაკლები → F (ჩაიჭრა) 

        // Console.WriteLine("Enter score: ");
        //
        // if (int.TryParse(Console.ReadLine(), out int score))
        // {
        //     switch (score)
        //     {
        //         case int n when (n >= 90 && n <=100):
        //             Console.WriteLine("A (fantastic) ");
        //             break;
        //         
        //         case int n when (n >= 80 && n <=89):
        //             Console.WriteLine("B (good) ");
        //             break;
        //         
        //         case int n when (n >= 70 && n <=79):
        //             Console.WriteLine("C (average) ");
        //             break;
        //         
        //         case int n when (n >= 60 && n <=69):
        //             Console.WriteLine("D (bad) ");
        //             break;
        //         
        //         case int n when (n <= 60):
        //             Console.WriteLine("F (fail) ");
        //             break;
        //         
        //         default:
        //             Console.WriteLine("Enter a valid score: ");
        //             break;
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Enter a valid score: ");
        // }
        #endregion
        
        #region task4
        
        // ექმენი პროგრამა, რომელიც: 
        // კითხულობს პროდუქტის ფასს 
        //     თუ ფასი 100 ლარზე მეტია → ხდება 20%-იანი ფასდაკლება 
        //     თუ ფასი 50-დან 100-მდეა → ხდება 10%-იანი ფასდაკლება 
        //     თუ 50-ზე ნაკლებია → ფასდაკლება არ ხდება 
        //     გამოიტანე საწყისი ფასი, ფასდაკლება და საბოლოო ფასი 

        // Console.WriteLine("Enter product price");
        //
        // if (decimal.TryParse(Console.ReadLine(), out decimal price) && price >= 0  )
        // {
        //     decimal discount = 0;
        //
        //     if (price > 100)
        //     {
        //         discount = price * 0.20m;
        //     } 
        //     else if (price >= 50 &&  price <= 100)
        //     {
        //         discount = price * 0.1m;
        //     }
        //      decimal finalPrice = price - discount;
        //      
        //      Console.WriteLine($"Original price: {price} USD");
        //      Console.WriteLine($"Discount: {discount} USD");
        //      Console.WriteLine($"Final price: {finalPrice} USD");
        // }
        // else
        // {
        //     Console.WriteLine("Invalid price");
        // }
        
        #endregion
        
        #region task5
        
        // დღის ნაწილი 
        // შექმენი პროგრამა, რომელიც კითხულობს საათს (0-23) და გამოიტანს დღის ნაწილს 
        // 6-11 → "დილა მშვიდობისა"  
        // 12-17 → "მოგესალმებით"  
        // 18-21 → "საღამო მშვიდობისა"  
        // 22-23 ან 0-5 → "ღამე მშვიდობისა"  

        // Console.WriteLine("Enter hour (0-23):");
        //
        // if (int.TryParse(Console.ReadLine(), out int hour) && hour >= 0 && hour <= 23)
        // {
        //     if (hour >= 6 && hour <= 11)
        //     {
        //         Console.WriteLine("Good Morning");
        //     }
        //     else if  (hour >= 12 && hour <= 17)
        //     {
        //         Console.WriteLine("Hello");
        //     }
        //     else if (hour >= 18 && hour <=21)
        //     {
        //         Console.WriteLine("Good Evening");
        //     }
        //     
        //     else
        //     {
        //         Console.WriteLine("Good Night");
        //     }
        // }
        //
        // else
        // {
        //     Console.WriteLine("Enter a valid hour");
        // }
        
        
        
        // ამ დავალებაში დამატებით მინდოდა ეს კოდი ჩამესვა, მაგრამ ამ კოდის გარეშეც იგივე ლოგიკაა და ამიტომ არ ჩავსვი.
        
        // else if (hour >= 22 && hour <= 23 || hour >= 0 && hour <= 5)
        // {
        //     Console.WriteLine("Good Night");
        // }
        
        #endregion
        
    }
}