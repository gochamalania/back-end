using Microsoft.EntityFrameworkCore;
using MovieDB.Application.Interfaces;
using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Infrastructure.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly MovieDbContext _context;

    public MovieRepository(MovieDbContext context)
    {
        _context = context;
    }

    public async Task<List<Movie>> GetAllAsync()
    {
        return await _context.Movies
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Movie?> GetByIdAsync(int id)
    {
        return await _context.Movies
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.Id == id);
    }

    public async Task<Movie> CreateAsync(Movie movie)
    {
        _context.Movies.Add(movie);

        await _context.SaveChangesAsync();

        return movie;
    }

    public async Task<bool> UpdateAsync(Movie movie)
    {
        var existingMovie = await _context.Movies
            .FirstOrDefaultAsync(m => m.Id == movie.Id);

        if (existingMovie == null)
        {
            return false;
        }

        existingMovie.Title = movie.Title;
        existingMovie.ReleaseYear = movie.ReleaseYear;
        existingMovie.StudioId = movie.StudioId;

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var movie = await _context.Movies
            .FirstOrDefaultAsync(m => m.Id == id);

        if (movie == null)
        {
            return false;
        }

        _context.Movies.Remove(movie);

        await _context.SaveChangesAsync();

        return true;
    }

    

    public async Task<List<Movie>> SearchMoviesByStudioAsync(
        int year,
        string studioName,
        int minimumActorCount)
    {
        return await _context.Movies
            .AsNoTracking()
            .Include(m => m.Studio)
            .Include(m => m.Actors)
            .Where(m =>
                m.ReleaseYear >= year &&
                m.Studio.Name == studioName &&
                m.Actors.Count >= minimumActorCount)
            .OrderByDescending(m => m.ReleaseYear)
            .ThenBy(m => m.Title)
            .ToListAsync();
    }

    

    public async Task<List<Movie>> SearchMoviesByCountryAsync(
        string countryName,
        int minimumYear,
        int maximumActorCount)
    {
        return await _context.Movies
            .AsNoTracking()
            .Include(m => m.Studio)
                .ThenInclude(s => s.Country)
            .Include(m => m.Actors)
            .Where(m =>
                m.Studio.Country.Name == countryName &&
                m.ReleaseYear >= minimumYear &&
                m.Actors.Count <= maximumActorCount)
            .OrderBy(m => m.Actors.Count)
            .ThenByDescending(m => m.ReleaseYear)
            .ThenBy(m => m.Title)
            .ToListAsync();
    }

    

    public async Task<List<Movie>> SearchMoviesAdvancedAsync(
        int fromYear,
        int toYear,
        string countryName,
        string titleText,
        int minimumActorCount)
    {
        return await _context.Movies
            .AsNoTracking()
            .Include(m => m.Studio)
                .ThenInclude(s => s.Country)
            .Include(m => m.Actors)
            .Where(m =>
                m.ReleaseYear >= fromYear &&
                m.ReleaseYear <= toYear &&
                m.Studio.Country.Name == countryName &&
                m.Title.Contains(titleText) &&
                m.Actors.Count >= minimumActorCount)
            .OrderByDescending(m => m.Actors.Count)
            .ThenByDescending(m => m.ReleaseYear)
            .ThenBy(m => m.Studio.Name)
            .ThenBy(m => m.Title)
            .ToListAsync();
    }
}