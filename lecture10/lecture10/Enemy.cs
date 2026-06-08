namespace lecture10;

public class Enemy : Sprite
{
   
    
    public int Health { get; set; }
    
    public int Demage { get; set; }
    
    
    public override void Move(int x, int y)
    {
        X += x;
        // Y += y;
    }

    public override void Drow()
    {
        Console.WriteLine("Enemy");
    }
}