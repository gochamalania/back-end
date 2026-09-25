using MovieDB.Application.Interfaces;
using MovieDB.Domain.Entities;

namespace MovieDB.Application.Services;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;

    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<List<Movie>> GetAllAsync()
    {
        return await _movieRepository.GetAllAsync();
    }

    public async Task<Movie?> GetByIdAsync(int id)
    {
        return await _movieRepository.GetByIdAsync(id);
    }

    public async Task<Movie> CreateAsync(Movie movie)
    {
        return await _movieRepository.CreateAsync(movie);
    }

    public async Task<bool> UpdateAsync(Movie movie)
    {
        return await _movieRepository.UpdateAsync(movie);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _movieRepository.DeleteAsync(id);
    }

    // ===============================
    // Search Methods
    // ===============================

    public async Task<List<Movie>> SearchMoviesByStudioAsync(
        int year,
        string studioName,
        int minimumActorCount)
    {
        return await _movieRepository.SearchMoviesByStudioAsync(
            year,
            studioName,
            minimumActorCount);
    }

    public async Task<List<Movie>> SearchMoviesByCountryAsync(
        string countryName,
        int minimumYear,
        int maximumActorCount)
    {
        return await _movieRepository.SearchMoviesByCountryAsync(
            countryName,
            minimumYear,
            maximumActorCount);
    }

    public async Task<List<Movie>> SearchMoviesAdvancedAsync(
        int fromYear,
        int toYear,
        string countryName,
        string titleText,
        int minimumActorCount)
    {
        return await _movieRepository.SearchMoviesAdvancedAsync(
            fromYear,
            toYear,
            countryName,
            titleText,
            minimumActorCount);
    }
}