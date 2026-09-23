using MovieDB.Domain.Entities;

namespace MovieDB.Application.Interfaces;

public interface ICountryRepository
{
    Task<List<Country>> GetAllAsync();
    Task<Country?> GetByIdAsync(int id);
    Task<Country> CreateAsync(Country country);
    Task<bool> UpdateAsync(Country country);
    Task<bool> DeleteAsync(int id);
}