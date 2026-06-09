namespace homeWork10Task2;

class Program
{
    static void Main(string[] args)
    {
        Worker[] workers =
        {
            new President("John", "Smith", 100000m, 50),
            new Engineer("Jane", "Doe", 50000m, 30),
            new Manager("Bob", "Smith", 70000m, 40),
            new Security("Sue", "Jones", 30000m, 25)
        };

        foreach (Worker worker in workers)
        {
            worker.Print();
        }
    }
}