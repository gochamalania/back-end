namespace MovieDB.Application.DTOs;

public class StudioDetailsDto
{
    public int Id { get; set; }
    public string LicenseNumber { get; set; } = string.Empty;
    public int StudioId { get; set; }
}