namespace MovieDB.Domain.Entities;

public class StudioDetails
{
    public int Id { get; set; }
    public string LicenseNumber { get; set; } = string.Empty;
    public int StudioId { get; set; }
    public Studio Studio { get; set; } = null!;
}