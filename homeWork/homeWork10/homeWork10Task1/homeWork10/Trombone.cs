namespace homeWork10;

public class Trombone : MusicalInstrument
{
    public Trombone(string name) : base(name) { }

    public override void Sound()
    {
        Console.WriteLine("Trombone sound: Waaaahhh 🎺");
    }

    public override void Desc()
    {
        Console.WriteLine("Trombone is a brass wind instrument with a slide.");
    }

    public override void History()
    {
        Console.WriteLine("Trombone appeared in the 15th century.");
    }
}