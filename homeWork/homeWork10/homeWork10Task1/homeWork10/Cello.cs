namespace homeWork10;

public class Cello : MusicalInstrument
{
    public Cello(string name) : base(name) { }

    public override void Sound()
    {
        Console.WriteLine("Cello sound: Ooooo deep 🎻");
    }

    public override void Desc()
    {
        Console.WriteLine("Cello is a large string instrument played sitting down.");
    }

    public override void History()
    {
        Console.WriteLine("Cello was developed in the 16th century in Italy.");
    }
}