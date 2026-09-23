using Microsoft.EntityFrameworkCore;
using MovieDB.Application.Interfaces;
using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Infrastructure.Repositories;

public class StudioRepository : IStudioRepository
{
    private readonly MovieDbContext _context;

    public StudioRepository(MovieDbContext context)
    {
        _context = context;
    }

    public async Task<List<Studio>> GetAllAsync()
    {
        return await _context.Studios
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Studio?> GetByIdAsync(int id)
    {
        return await _context.Studios
            .AsNoTracking()
            .FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task<Studio> CreateAsync(Studio studio)
    {
        _context.Studios.Add(studio);

        await _context.SaveChangesAsync();

        return studio;
    }

    public async Task<bool> UpdateAsync(Studio studio)
    {
        var existingStudio = await _context.Studios
            .FirstOrDefaultAsync(s => s.Id == studio.Id);

        if (existingStudio == null)
        {
            return false;
        }

        existingStudio.Name = studio.Name;
        existingStudio.CountryId = studio.CountryId;

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var studio = await _context.Studios
            .FirstOrDefaultAsync(s => s.Id == id);

        if (studio == null)
        {
            return false;
        }

        _context.Studios.Remove(studio);

        await _context.SaveChangesAsync();

        return true;
    }
}