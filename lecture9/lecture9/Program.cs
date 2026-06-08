namespace lecture9;

class Program
{
    static void Main(string[] args)
    {
        #region homeWork

        // string path = @"../../../CarsData.txt";
        //
        // string[] strings = File.ReadAllLines(path);
        //
        // Car[] cars = new Car[strings.Length];
        //
        //
        // for (int i = 0; i < strings.Length; i++)
        // {
        //     string[] data = strings[i].Split(',');
        //
        //     cars[i] = new Car();
        //     cars[i].Brand = data[0];
        //     cars[i].Model = data[1];
        //     cars[i].Year = int.Parse(data[2]);
        //     cars[i].Price = Decimal.Parse(data[3]);
        //     cars[i].Color = (Color)Enum.Parse(typeof(Color), data[4]);
        // }
        //
        // cars[0].PrintInfo();
        //
        // Car.PrintAllCarsInfo(cars);

        #endregion
        
        
        // მემკვირდრეობა
        Teacher t = new Teacher();
        t.Name = "John";
        t.LastName = "Doe";
        t.Age = 30;
        t.Salary = 1000m;
        Console.WriteLine($"name: {t.Name} age: {t.Age} salary: {t.Salary}");

        Lesson les = new Lesson();
        Lesson les2 = new Lesson();
        t.Lessons = [les, les2];

        Console.WriteLine("bonus: " + t.GetBonus());
        
        t.PrintInfo();
        
        
        
        Student s = new Student();
        s.Name = "Jane";
        s.LastName = "Smith";
        s.Age = 20;
        s.Grade = 12;
        Console.WriteLine($"name: {s.Name} age: {s.Age} grade: {s.Grade}");
        
        
        Manager m = new Manager();
        m.Name = "Bob";
        m.LastName = "Johnson";
        m.Age = 40;
        m.Salary = 2000m;
        Console.WriteLine($"name: {m.Name} age: {m.Age} salary: {m.Salary}");

    }
}