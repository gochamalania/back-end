using MovieDB.Domain.Entities;

namespace MovieDB.Application.Interfaces;

public interface IStudioRepository
{
    Task<List<Studio>> GetAllAsync();
    Task<Studio?> GetByIdAsync(int id);
    Task<Studio> CreateAsync(Studio studio);
    Task<bool> UpdateAsync(Studio studio);
    Task<bool> DeleteAsync(int id);
}