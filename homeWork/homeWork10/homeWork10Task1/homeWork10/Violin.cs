namespace homeWork10;

public class Violin : MusicalInstrument
{
    public Violin(string name) : base(name) { }

    public override void Sound()
    {
        Console.WriteLine("Violin sound: Viiiin Viiiin 🎻");
    }

    public override void Desc()
    {
        Console.WriteLine("Violin is a string instrument played with a bow.");
    }

    public override void History()
    {
        Console.WriteLine("Violin was developed in 16th century Italy.");
    }
}