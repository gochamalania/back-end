namespace homeWork11_task_2;

class Program
{
    static void Main(string[] args)
    {
        
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 3, 5, 30, 50, 54, 45, 30};
        
        
        ArrayContainer arrayContainer = new ArrayContainer(numbers);

        Console.WriteLine("Array: ");

        foreach (var n in numbers)
        {
            Console.WriteLine(n + " ");
        }

        Console.WriteLine("\n");

        Console.WriteLine($"Distinct numbers: {arrayContainer.CountDistinct()}");

        int value = 10;
        Console.WriteLine($"Value {value} is in array: {arrayContainer.EqualToValue(value)} times");


    }
}