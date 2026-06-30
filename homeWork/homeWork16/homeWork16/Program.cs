using homeWork16.Extensions;

namespace homeWork16;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>()
        {
            10,
            15,
            20,
            30,
            40,
            50,
            20,
            30,
        };
        
        
        // Where
        Console.WriteLine("======== Where ========");
        List<int> filtered = MyEnumerable.Where(numbers, x => x > 25);
        foreach (int number in filtered)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
        
        
        // any
        Console.WriteLine("======== Any ========");
        Console.WriteLine(MyEnumerable.Any(numbers, x => x == 40));
        Console.WriteLine();
        
        
        // All
        Console.WriteLine("======== All ========");
        Console.WriteLine(MyEnumerable.All(numbers, x => x > 5));
        Console.WriteLine();
        
        
        // Count
        Console.WriteLine("======== Count ========");
        Console.WriteLine(MyEnumerable.Count(numbers, x => x >= 20));
        Console.WriteLine();
        
        
        // First
        Console.WriteLine("======== First ========");
        Console.WriteLine(MyEnumerable.First(numbers, x => x > 25));
        Console.WriteLine();
        
        
        // First or default
        Console.WriteLine("======== FirstOrDefault ========");
        Console.WriteLine(MyEnumerable.FirstOrDefault(numbers, x => x > 100));
        Console.WriteLine();
        
        
        // Single
        Console.WriteLine("======== Single ========");
        Console.WriteLine(MyEnumerable.Single(numbers, x => x == 40));
        Console.WriteLine();
        
        
        // Single or Default
        Console.WriteLine("======== SingleOrDefault ========");
        Console.WriteLine(MyEnumerable.SingleOrDefault(numbers, x => x == 100));
        Console.WriteLine();
        
        
        // Distinct
        Console.WriteLine("======== Distinct ========");
        List<int> distinct = MyEnumerable.Distinct(numbers);
        foreach (int number in distinct)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
        
        
        // OrderBy
        Console.WriteLine("======== OrderBy ========");
        List<int> sorted = MyEnumerable.OrderBy(numbers, x => x);
        foreach (int number in sorted)
        {
            Console.WriteLine(number);
        }
    }
}