using Microsoft.EntityFrameworkCore;
using MovieDB.Application.Interfaces;
using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Infrastructure.Repositories;

public class ActorRepository : IActorRepository
{
    private readonly MovieDbContext _context;

    public ActorRepository(MovieDbContext context)
    {
        _context = context;
    }

    public async Task<List<Actor>> GetAllAsync()
    {
        return await _context.Actors
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Actor?> GetByIdAsync(int id)
    {
        return await _context.Actors
            .AsNoTracking()
            .FirstOrDefaultAsync(a => a.Id == id);
    }

    public async Task<Actor> CreateAsync(Actor actor)
    {
        _context.Actors.Add(actor);

        await _context.SaveChangesAsync();

        return actor;
    }

    public async Task<bool> UpdateAsync(Actor actor)
    {
        var existingActor = await _context.Actors
            .FirstOrDefaultAsync(a => a.Id == actor.Id);

        if (existingActor == null)
        {
            return false;
        }

        existingActor.FirstName = actor.FirstName;
        existingActor.LastName = actor.LastName;

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var actor = await _context.Actors
            .FirstOrDefaultAsync(a => a.Id == id);

        if (actor == null)
        {
            return false;
        }

        _context.Actors.Remove(actor);

        await _context.SaveChangesAsync();

        return true;
    }
}