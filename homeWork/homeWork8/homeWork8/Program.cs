namespace homeWork8;

class Program
{
    static void Main(string[] args)
    {
        string path = @"../../../CarsData.txt";

        string[] lines = File.ReadAllLines(path);

        Car[] cars = new Car[lines.Length];

        int index = 0;

        foreach (string line in lines)
        {
            string cleanLine = line.Trim();

            int dotIndex = cleanLine.IndexOf('.');
            cleanLine = cleanLine[(dotIndex + 1)..].Trim();

            string[] parts = cleanLine.Split(',');

            bool validYear = int.TryParse(parts[2], out int year);
            bool validPrice = decimal.TryParse(parts[3], out decimal price);
            bool validColor = Enum.TryParse(parts[4], out Car.Color color);

            if (!validYear || !validPrice || !validColor)
            {
                Console.WriteLine($"Invalid data: {line}");
                continue;
            }

            cars[index] = new Car(parts[0], parts[1], year, color, price);
            index++;
        }

        Console.WriteLine("===== ALL CARS =====");

        for (int i = 0; i < index; i++)
        {
            cars[i].PrintInfo();
        }

        Console.WriteLine("\n===== TEST =====");

        if (index > 0)
        {
            Car first = cars[0];

            first.PrintInfo();
            Console.WriteLine($"Age: {first.GetAge()}");
            Console.WriteLine($"Expensive: {first.IsExpensive()}");

            first.ApplyDiscount(10);
            Console.WriteLine("After discount:");
            first.PrintInfo();

            first.ChangeColor(Car.Color.Black);
            Console.WriteLine("After color change:");
            first.PrintInfo();
        }
    }
}