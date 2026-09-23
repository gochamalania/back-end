using MovieDB.Application.Interfaces;
using MovieDB.Domain.Entities;

namespace MovieDB.Application.Services;

public class MovieActorService : IMovieActorService
{
    private readonly IMovieActorRepository _movieActorRepository;

    public MovieActorService(IMovieActorRepository movieActorRepository)
    {
        _movieActorRepository = movieActorRepository;
    }

    public async Task<List<Actor>> GetActorsByMovieIdAsync(int movieId)
    {
        return await _movieActorRepository
            .GetActorsByMovieIdAsync(movieId);
    }

    public async Task<bool> AddActorToMovieAsync(int movieId, int actorId)
    {
        return await _movieActorRepository
            .AddActorToMovieAsync(movieId, actorId);
    }

    public async Task<bool> RemoveActorFromMovieAsync(int movieId, int actorId)
    {
        return await _movieActorRepository
            .RemoveActorFromMovieAsync(movieId, actorId);
    }
}