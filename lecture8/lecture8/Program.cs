namespace lecture8;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        #region classWork

        // int[] numbers = { 5, 7, 10, 100, -4, -7, -99, 199 };
        //
        // int min = FindMin(numbers);
        // int max = FindMax(numbers);
        //
        // Console.WriteLine($"Min: {min} ({GetSign(min)})");
        // Console.WriteLine($"Max: {max} ({GetSign(max)})");
        //
        // int FindMin(int[] array)
        // {
        //     int minValue = array[0];
        //
        //     for (int i = 1; i < array.Length; i++)
        //     {
        //         if (array[i] < minValue)
        //         {
        //             minValue = array[i];
        //         }
        //     }
        //     return minValue;
        // }
        //
        // int FindMax(int[] array)
        // {
        //     int maxValue = array[0];
        //
        //     for (int i = 1; i < array.Length; i++)
        //     {
        //         if (array[i] > maxValue)
        //         {
        //             maxValue = array[i];
        //         }
        //     }
        //     return maxValue;
        // }
        //
        // string GetSign(int number)
        // {
        //     if (number > 0)
        //     {
        //         return "Positive";
        //     }
        //     else if (number < 0)
        //     {
        //         return "Negative";
        //     }
        //     else
        //     {
        //         return "Zero";
        //     }
        // }

        #endregion

        #region task
        
        // int[] numbers = { 5, 7, 10, 100, -4, -7, -99, 199 };
        //
        // FindMinMax(numbers, out int min, out int max);
        //
        // void FindMinMax(int[] nums, out int min, out int max)
        // {
        //     min = nums[0];
        //     max = nums[0];
        //
        //     foreach (var item in nums)
        //     {
        //         if (item < 0)
        //         {
        //             min = item;
        //         }
        //         else if (item > max)
        //         {
        //             max = item;
        //         }
        //     }
        //
        //     Console.WriteLine($"Min: {min} ({CheakNumber(min)})");
        //     Console.WriteLine($"Max: {max} ({CheakNumber(max)})");
        //     
        // }
        //
        // string CheakNumber(int num)
        // {
        //     if (num > 0)
        //     {
        //         return "Positive";
        //     } else if (num < 0)
        //     {
        //         return "Negative";
        //     }
        //     else
        //     {
        //         return "Zero";
        //     }
        // }
        
        #endregion


        Product product1 = new()
        {
            Name = "Product 2"
        };
        
        // product1.Id = 50;

        product1.Id = 1;
        // product1.Name = "Product 1";
        
        
        // product1.Name = "Product 2";
        
        product1.Price = 100m;
        product1.Description = "Description of Product 1";
        product1.Category = "Category 1";
        product1.Quantity = 10;
        product1.Rating = 4.5f;
        product1.IsAvailable = true;
        
        product1.DisplayInfo();
        
        product1.AddStock(5);
        
        product1.DisplayInfo();
     
        Console.WriteLine(product1.Sale(10m));

    }
}