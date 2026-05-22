namespace homeWork5_array;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");


        #region task1

        // დავალება 1
        //      შექმენით ერთ განზომილებიანი ორი მასივი.
        //      შეავსეთ ორივე მასივი ელემენტებით.
        //      გააერთიანე ერთ მასივში ორივე მასივის ელემენტები.
        //      დაბეჭდეთ საბოლოოდ მიღებული მასივი.
        //     მაგალითად, თუ პირველი მასივის ელემენტების: 1 2 3
        // ხოლო მეორე მასივის ელემენტებია : 4 5 6
        // შედეგად უნდა მიიღოთ:
        // resultArray = [1, 2, 3, 4, 5, 6]

        // int[] firstArray = { 1, 2, 3, };
        // int[] secondArray = { 4, 5, 6, };
        //
        // int[] resultArray = new int[firstArray.Length +  secondArray.Length];
        //
        // for (int i = 0; i < firstArray.Length; i++)
        // {
        //     resultArray[i] = firstArray[i];
        // }
        //
        // for (int i = 0; i < secondArray.Length; i++)
        // {
        //     resultArray[firstArray.Length + i] = secondArray[i];
        // }
        //
        // Console.WriteLine("Result array: ");
        //
        // for (int i = 0; i < resultArray.Length; i++)
        // {
        //     Console.Write(resultArray[i] + " ");
        // }
        
        
        // justForFun
        // int[] firstArray = new int[3];
        // int[] secondArray = new int[3];
        //
        // Console.WriteLine("Enter 3 numbers for first array: ");
        //
        // for (int i = 0; i < firstArray.Length; i++)
        // {
        //     while (!int.TryParse(Console.ReadLine(), out firstArray[i]))
        //     {
        //         Console.WriteLine("Enter a valid number");
        //     }
        // }
        //
        // Console.WriteLine("Enter 3 numbers for second array: ");
        //
        // for (int i = 0; i < secondArray.Length; i++)
        // {
        //     while (!int.TryParse(Console.ReadLine(), out secondArray[i]))
        //     {
        //         Console.WriteLine("Enter a valid number");
        //     }
        // }
        //
        // int[] resultArray = new int[firstArray.Length + secondArray.Length];
        //
        // for (int i = 0; i < firstArray.Length; i++)
        // {
        //     resultArray[i] = firstArray[i];
        // }
        //
        // for (int i = 0; i < secondArray.Length; i++)
        // {
        //     resultArray[firstArray.Length + i] = secondArray[i];
        // }
        //
        //
        // Console.WriteLine("Merged array: ");
        //
        // for (int i = 0; i < resultArray.Length; i++)
        // {
        //     Console.WriteLine(resultArray[i] + " ");
        // }

        #endregion
        
        #region task2
        
        // დავალება 2
        //      შექმენით ინტების მასივი და შეავსეთ ელემენტებით. მაგ: 3, 5, -4, 8, 11, 1, -1, 6
        //      კონსოლიდან გადმოეცით რაღაც რიცხვი რომელსაც შეინახავთ targetSum ცვლადში.
        //      მოძებნეთ მასივში ყველა ის ორი ელემენტი რომლის ჯამიც იქნება targetSum ტოლი და ამ
        //     წყვილებისგან შექმენით მასივი.
        //      დააბრუნეთ ამ ელემენტების წყვილები კონსოლში
        // მაგალითად:
        // array = {3, 5, -4, 8, 11, 1, -1, 6}
        // targetSum = 7
        // შედეგად უნდა მივიღოთ:
        // resultArray = [ [1, 6], [8, -1], [-4, 11]]

        // int[] numbers = { 3, 5, -4, 8, 11, 1, -1, 6 };
        // Console.WriteLine("Enter target sum: ");
        //
        // int targetSum;
        //
        // while (!int.TryParse(Console.ReadLine(), out targetSum))
        // {
        //     Console.WriteLine("Enter a valid number: ");
        // }
        //
        // Console.WriteLine("Pairs: ");
        //
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     for (int j = i + 1; j < numbers.Length; j++)
        //     {
        //         if (numbers[i] + numbers[j] == targetSum)
        //         {
        //             Console.WriteLine($"[{numbers[i]}, {numbers[j]}]");
        //         }
        //     }
        // }
 
        #endregion


    }
}
