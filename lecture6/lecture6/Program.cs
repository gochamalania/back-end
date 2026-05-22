namespace lecture6;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");



        // int[,] arr2D =
        // {
        //     { 1, 2 }, 
        //     { 4, 5 }
        // };
        //
        // Console.WriteLine(arr2D[0, 0]);
        // Console.WriteLine(arr2D[0, 1]);
        //
        // Console.WriteLine(arr2D[1, 0]);
        // Console.WriteLine(arr2D[1, 1]);
        
        
        // jaggedArray

        // int[][] jagged = 
        // [
        //     [20], 
        //     [20,60, 30], 
        //     [50, 60]
        // ];
        
        // Console.WriteLine(jagged[0][0]);
        // Console.WriteLine(jagged[1][1]);
        // Console.WriteLine(jagged[2][1]);
        
        
        // int[][] jagged2 = new int[2][];


        
        // int[][] jagged = 
        // [
        //     [20], 
        //     [20,60, 30], 
        //     [50, 60]
        // ];
        //
        // int sum = 0;
        //
        // for (int i = 0; i < jagged.Length; i++)
        // {
        //     for (int j = 0; j < jagged[i].Length; j++)
        //     {
        //         Console.WriteLine(jagged[i][j]);
        //         sum += jagged[i][j];
        //     }
        // }
        //
        // Console.WriteLine(sum);
        
        
        
        // ArrayMethods
        // int[] nums = [1, 60, 30, 70];
        // Console.WriteLine(Array.IndexOf(nums, 30));
        // Console.WriteLine(Array.LastIndexOf(nums, 30));
        //
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     if (nums[i] == 30 && i != Array.IndexOf(nums, 30))
        //     {
        //         Console.WriteLine(i);
        //     }
        // }
        
        // LINQ
        // int[] nums = [1, 60, 30, 70, 50, 40];
        // // Console.WriteLine(nums.ToString());
        //
        // Array.Resize(ref nums, nums.Length + 1);
        //
        // nums[6] = 100;


        // string text = "stringText";
        //
        // string text2 = "stringText2";
        
        // if (text2 == text) //true


        // string text = "text";
        // Console.WriteLine(text[2]);
        //
        // for (int  i = 0;  i < text.Length; i++)
        // {
        //     Console.WriteLine(text[i]);
        // }
        
        // step on no pets
        // string text = "text";
        // char[] symbols = text.ToCharArray();
        //
        // char[] reversedsymbols = text.ToCharArray().Reverse().ToArray();
        //
        // bool isPalindrome = true;
        //
        // for (int i = 0; i < symbols.Length; i++)
        // {
        //     if (symbols[i] != reversedsymbols[i])
        //     {
        //         isPalindrome = false;
        //     }
        // }
        //
        // Console.WriteLine(isPalindrome);


        // string text = "Hello World!";
        // Console.WriteLine(text.Substring(3));
        // Console.WriteLine(text.Substring(3, 5));
        //
        // Console.WriteLine(text.Contains("@"));
        //
        // Console.WriteLine(text.IndexOf("o"));
        //
        // Console.WriteLine(text.ToUpper());
        // Console.WriteLine(text.ToLower());
        // Console.WriteLine(text.Trim());

        // string name = "john";
        // name.Replace(name[0], name[0].ToString().ToUpper()[0]);
        
        // string name = "john";
        // string result = char.ToUpper(name[0]) + name.Substring(1);
        // Console.WriteLine(result);
        //
        
        
        
        // CSV name,lastname,age
        // string text5 = "John, Doe, 20";
        // string[] info = text5.Split(',');
        // Console.WriteLine(info[0]);
        // Console.WriteLine(info[1]);
        


    }
}
