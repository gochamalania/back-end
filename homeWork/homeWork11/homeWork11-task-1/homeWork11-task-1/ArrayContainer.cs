namespace homeWork11_task_1;

public class ArrayContainer
{
    private int[] _numbers;

    public int[] Numbers
    {
        get => _numbers;
        set
        {
            if (value == null || value.Length == 0)
            {
                Console.WriteLine("Array must not be null or empty");
                return;
            }
            
            _numbers = value;
        }
    }

    public ArrayContainer(int[] numbers)
    {
        Numbers = numbers;
    }

    public void ShowEven()
    {
        Console.WriteLine("Even numbers: ");

        bool found = false;

        foreach (int number in Numbers)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number);
                found = true;
            }
            
        }
        
        if (!found)
        {
            Console.WriteLine("No even numbers");
        }
    }

    public void ShowOdd()
    {
        Console.WriteLine("Odd numbers: ");
        
        bool found = false;
        
        foreach (int number in Numbers)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine(number);
                found = true;
            }
            
        }

        if (!found)
        {
            Console.WriteLine("No odd numbers");
        }
    }
}