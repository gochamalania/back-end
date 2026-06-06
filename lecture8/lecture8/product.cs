namespace lecture8;

public class Product
{
    private int _id;



    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            if (value > 0)
            {
                _id = value;
            }
        }
    }
    
    
    
    public string Name { get; init; }
    public const int MinQuantity = 1; //const მუდმივა, სულ, 1-ზე ნაკლები არ უნდა იყოს.
    // public readonly DateTime CreatedAt = DateTime.Now;

    // public DateTime CreatedAt;
    // public Product(DateTime createdAt)
    // {
    //     CreatedAt = createdAt;
    // }

    
    
    
    
    // public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Category { get; set; }
    public float Rating { get; set; }
    
    public bool IsAvailable { get; set; }


    public void DisplayInfo()
    {
        Console.WriteLine(
            $"Id: {Id} Name: {Name} " +
            $"Description: {Description} " +
            $"Price: {Price} " +
            $"Quantity: {Quantity} " +
            $"Category: {Category} " +
            $"Rating: {Rating} " +
            $"IsAvailable: {IsAvailable}"
        );
    }
    
    public void AddStock(int amount)
    {
        Console.WriteLine("Adding stock...");
        Quantity += amount;
        Console.WriteLine($"Stock added. New quantity: {Quantity}");
    }

    public decimal Sale(decimal discount)
    {
        return Price - Price * discount / 100;
    }
    
}
