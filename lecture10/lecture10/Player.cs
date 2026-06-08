namespace lecture10;

public class Player : Sprite
{
    
    
    
    public int Health { get; set; }
    
    public int Life { get; set; }
    public int Points { get; set; }




    public override void Move(int x, int y)
    {
        X += x;
        Y += y;

        Console.WriteLine($"Player moved to X: {X}, Y: {Y}");
    }
    
    public override void Drow()
    {
        Console.WriteLine("Player");
    }
    
    
}