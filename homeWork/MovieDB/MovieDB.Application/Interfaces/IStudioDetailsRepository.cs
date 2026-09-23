using MovieDB.Domain.Entities;

namespace MovieDB.Application.Interfaces;

public interface IStudioDetailsRepository
{
    Task<StudioDetails?> GetByStudioIdAsync(int studioId);
    Task<StudioDetails> CreateAsync(StudioDetails studioDetails);
    Task<bool> UpdateAsync(StudioDetails studioDetails);
    Task<bool> DeleteAsync(int studioId);
}