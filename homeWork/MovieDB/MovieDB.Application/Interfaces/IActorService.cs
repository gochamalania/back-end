using MovieDB.Domain.Entities;

namespace MovieDB.Application.Interfaces;

public interface IActorService
{
    Task<List<Actor>> GetAllAsync();
    Task<Actor?> GetByIdAsync(int id);
    Task<Actor> CreateAsync(Actor actor);
    Task<bool> UpdateAsync(Actor actor);
    Task<bool> DeleteAsync(int id);
}