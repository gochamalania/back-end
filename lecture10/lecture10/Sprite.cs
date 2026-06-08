namespace lecture10;

public abstract class Sprite
{
    public string Name { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    
    public bool IsOnScreen { get; set; }
    
    
    
    public virtual void Move(int x, int y)
    {
        X += x;
        Y += y;
    }
    
    
    public abstract void Drow();
    
    
    
    
}