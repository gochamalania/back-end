namespace MovieDB.Domain.Entities;

public class Actor
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public ICollection<Movie> Movies { get; set; } = new List<Movie>();
}