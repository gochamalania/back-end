namespace homeWork10;

public abstract class MusicalInstrument
{
    public string Name { get; set; }

    public MusicalInstrument(string name)
    {
        Name = name;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Instrument: {Name}");
    }

    public abstract void Sound();
    public abstract void Desc();
    public abstract void History();


}