using MovieDB.Domain.Entities;

namespace MovieDB.Application.Interfaces;

public interface IMovieActorRepository
{
    Task<List<Actor>> GetActorsByMovieIdAsync(int movieId);
    Task<bool> AddActorToMovieAsync(int movieId, int actorId);
    Task<bool> RemoveActorFromMovieAsync(int movieId, int actorId);
}