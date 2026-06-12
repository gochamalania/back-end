namespace homeWork11_task_1;

class Program
{
    static void Main(string[] args)
    {
        
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 35, 45};
        
        
        ArrayContainer arrayContainer = new ArrayContainer(numbers);
        
        arrayContainer.ShowEven();
        Console.WriteLine();
        arrayContainer.ShowOdd();
        
    }
}