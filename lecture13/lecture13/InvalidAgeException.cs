namespace lecture13;

public class InvalidAgeException : Exception
{
    
    public InvalidAgeException(string? message) : base(message)
    {
        
    }
    
    
    public InvalidAgeException() : base( "Age is not valid")
    {
        
    }
    
    
}