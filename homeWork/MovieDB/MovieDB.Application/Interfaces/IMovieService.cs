using MovieDB.Domain.Entities;

namespace MovieDB.Application.Interfaces;

public interface IMovieService
{
    Task<List<Movie>> GetAllAsync();
    Task<Movie?> GetByIdAsync(int id);
    Task<Movie> CreateAsync(Movie movie);
    Task<bool> UpdateAsync(Movie movie);
    Task<bool> DeleteAsync(int id);
}