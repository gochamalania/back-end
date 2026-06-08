namespace lecture9;

internal class Car
{
    // Toyota,Corolla,2022,25000,White

    private string _brand;

    private string _model;

    private int _year;

    private decimal _price;

    private Color _color;


    public string Brand
    {
        get { return _brand; }
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
        get { return _model; }
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
        get { return _year; }
        set
        {
            if (!int.TryParse(value.ToString(), out _year))
            {
                Console.WriteLine("Year must be a number");
                return;
            }
            else if (value < 1900 || value > DateTime.Now.Year)
            {
                Console.WriteLine("Year must be between 1900 and current year");
                return;
            }

            _year = value;
        }
    }


    public decimal Price
    {
        get { return _price; }
        set
        {
            if (!decimal.TryParse(value.ToString(), out _price))
            {
                Console.WriteLine("Price must be a number");
                return;
            }
            else if (value <= 0)
            {
                Console.WriteLine("Price must be greater than 0");
                return;
            }

            _price = value;
        }
    }


    public Color Color
    {
        get { return _color; }
        set
        {
            if (!Color.TryParse(value.ToString(), out _color))
            {
                Console.WriteLine("Color cannot be empty");
                return;
            }

            _color = value;
        }
    }

    // methods
    public void PrintInfo()
    {
        Console.WriteLine($"Brand: {_brand}");
        Console.WriteLine($"Model: {_model}");
        Console.WriteLine($"Year: {_year}");
        Console.WriteLine($"Price: {_price}");
        Console.WriteLine($"Color: {_color}");
    }

    public static void PrintAllCarsInfo(Car[] cars)
    {
        foreach (var car in cars)
        {
            // Console.WriteLine
            // (
            //     $"Brand: {car.Brand}, " +
            //     $"Model: {car.Model}, " +
            //     $"Year: {car.Year}, " +
            //     $"Price: {car.Price}, " +
            //     $"Color: {car.Color}"
            // );

            Console.WriteLine(car.ToString());
            
        }
    }

    public static bool Equals(Car? car, Car? other)
    {
        if (car.Model == other.Model && car.Year == other.Year )
        {
            return true;
        }
        return false;
    }

    // public override int GetHashCode()
    // {
    //     return base.GetHashCode();
    // }

    public override string? ToString()
    {
        return $"{Brand}, {Model}, {Year}, {Price}, {Color}";
    }
}

public enum Color : byte
{
    Red = 10,
    Blue,
    Green,
    Yellow,
    White,
    Pink,
    Silver,
    Black,
    Brown,
    Gray,
    FluidMetal,
    MidnightPurple,
}