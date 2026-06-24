namespace homeWork13_project;

public class Logger : IDisposable
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG : {message}");
    }

    public void Dispose()
    {
        Console.WriteLine("Logger disposed");
    }
}