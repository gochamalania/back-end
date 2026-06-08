namespace homeWork8;

internal class Car
{
    private string _brand;
    private string _model;
    private int _year;
    private Color _color;
    private decimal _price;

    public enum Color
    {
        White,
        Black,
        Silver,
        Gray,
        Red,
        Blue,
        FluidMetal,
        Yellow,
        MidnightPurple
    }

    public string Brand
    {
        get => _brand;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Brand cannot be empty");
                return;
            }

            _brand = value.Trim();
        }
    }

    public string Model
    {
        get => _model;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Model cannot be empty");
                return;
            }

            _model = value.Trim();
        }
    }

    public int Year
    {
        get => _year;
        set
        {
            if (value < 1900 || value > DateTime.Now.Year)
            {
                Console.WriteLine("Invalid year");
                return;
            }

            _year = value;
        }
    }

    public decimal Price
    {
        get => _price;
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Price must be greater than 0");
                return;
            }

            _price = value;
        }
    }

    public Color CarColor
    {
        get => _color;
        set => _color = value;
    }

    public Car(string brand, string model, int year, Color color, decimal price)
    {
        Brand = brand;
        Model = model;
        Year = year;
        CarColor = color;
        Price = price;
    }

    // prints cars info
    public void PrintInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Color: {CarColor}, Price: {Price}");
    }
    
    
    // Using discounts
    public void ApplyDiscount(decimal percent)
    {
        if (percent <= 0 || percent > 100)
        {
            Console.WriteLine("Invalid discount");
            return;
        }
        Price -= (Price * percent) / 100;
    }
    
    // calcularing the age off car
    public int GetAge()
    {
        return DateTime.Now.Year - Year;
    }
    
    // expensive or not
    public bool IsExpensive()
    {
        return Price >= 50000;
    }
    
    // change color
    public void ChangeColor(Color newColor)
    {
        CarColor = newColor;
    }
    
    
}