using MovieDB.Application.Interfaces;
using MovieDB.Domain.Entities;

namespace MovieDB.Application.Services;

public class ActorService : IActorService
{
    private readonly IActorRepository _actorRepository;

    public ActorService(IActorRepository actorRepository)
    {
        _actorRepository = actorRepository;
    }

    public async Task<List<Actor>> GetAllAsync()
    {
        return await _actorRepository.GetAllAsync();
    }

    public async Task<Actor?> GetByIdAsync(int id)
    {
        return await _actorRepository.GetByIdAsync(id);
    }

    public async Task<Actor> CreateAsync(Actor actor)
    {
        return await _actorRepository.CreateAsync(actor);
    }

    public async Task<bool> UpdateAsync(Actor actor)
    {
        return await _actorRepository.UpdateAsync(actor);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _actorRepository.DeleteAsync(id);
    }
}