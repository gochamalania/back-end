using MovieDB.Domain.Entities;

namespace MovieDB.Application.Interfaces;

public interface IMovieRepository
{
    Task<List<Movie>> GetAllAsync();
    Task<Movie?> GetByIdAsync(int id);
    Task<Movie> CreateAsync(Movie movie);
    Task<bool> UpdateAsync(Movie movie);
    Task<bool> DeleteAsync(int id);

    

    Task<List<Movie>> SearchMoviesByStudioAsync(
        int year,
        string studioName,
        int minimumActorCount);

    Task<List<Movie>> SearchMoviesByCountryAsync(
        string countryName,
        int minimumYear,
        int maximumActorCount);

    Task<List<Movie>> SearchMoviesAdvancedAsync(
        int fromYear,
        int toYear,
        string countryName,
        string titleText,
        int minimumActorCount);
}