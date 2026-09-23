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
}