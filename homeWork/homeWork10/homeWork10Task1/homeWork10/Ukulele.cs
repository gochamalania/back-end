namespace homeWork10;

public class Ukulele : MusicalInstrument
{
    public Ukulele(string name) : base(name) { }

    public override void Sound()
    {
        Console.WriteLine("Ukulele sound: Strum strum 🎶");
    }

    public override void Desc()
    {
        Console.WriteLine("Ukulele is a small guitar-like instrument from Hawaii.");
    }

    public override void History()
    {
        Console.WriteLine("Ukulele originated in the 19th century in Hawaii.");
    }
}