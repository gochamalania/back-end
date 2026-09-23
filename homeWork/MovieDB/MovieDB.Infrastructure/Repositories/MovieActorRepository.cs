using Microsoft.EntityFrameworkCore;
using MovieDB.Application.Interfaces;
using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Infrastructure.Repositories;

public class MovieActorRepository : IMovieActorRepository
{
    private readonly MovieDbContext _context;

    public MovieActorRepository(MovieDbContext context)
    {
        _context = context;
    }

    public async Task<List<Actor>> GetActorsByMovieIdAsync(int movieId)
    {
        var movie = await _context.Movies
            .Include(m => m.Actors)
            .FirstOrDefaultAsync(m => m.Id == movieId);

        if (movie == null)
        {
            return new List<Actor>();
        }

        return movie.Actors.ToList();
    }

    public async Task<bool> AddActorToMovieAsync(int movieId, int actorId)
    {
        var movie = await _context.Movies
            .Include(m => m.Actors)
            .FirstOrDefaultAsync(m => m.Id == movieId);

        if (movie == null)
        {
            return false;
        }

        var actor = await _context.Actors
            .FirstOrDefaultAsync(a => a.Id == actorId);

        if (actor == null)
        {
            return false;
        }

        if (movie.Actors.Any(a => a.Id == actorId))
        {
            return false;
        }

        movie.Actors.Add(actor);

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> RemoveActorFromMovieAsync(int movieId, int actorId)
    {
        var movie = await _context.Movies
            .Include(m => m.Actors)
            .FirstOrDefaultAsync(m => m.Id == movieId);

        if (movie == null)
        {
            return false;
        }

        var actor = movie.Actors
            .FirstOrDefault(a => a.Id == actorId);

        if (actor == null)
        {
            return false;
        }

        movie.Actors.Remove(actor);

        await _context.SaveChangesAsync();

        return true;
    }
}