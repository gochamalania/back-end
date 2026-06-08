namespace homeWork9;

public static class Helpers
{
    public static void PrintByCountry(Employ[] employs, Country country)
    {
        foreach (var emp in employs)
        {
            if (emp.Country == country)
            {
                Console.WriteLine($"{emp.Name} {emp.LastName} | {emp.Country} | {emp.Gender} | Age: {emp.GetAge()}");
            }
        }
    }
}