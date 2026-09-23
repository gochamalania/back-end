using Microsoft.EntityFrameworkCore;
using MovieDB.Application.Interfaces;
using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Infrastructure.Repositories;

public class StudioDetailsRepository : IStudioDetailsRepository
{
    private readonly MovieDbContext _context;

    public StudioDetailsRepository(MovieDbContext context)
    {
        _context = context;
    }

    public async Task<StudioDetails?> GetByStudioIdAsync(int studioId)
    {
        return await _context.StudioDetails
            .AsNoTracking()
            .FirstOrDefaultAsync(sd => sd.StudioId == studioId);
    }

    public async Task<StudioDetails> CreateAsync(StudioDetails studioDetails)
    {
        _context.StudioDetails.Add(studioDetails);

        await _context.SaveChangesAsync();

        return studioDetails;
    }

    public async Task<bool> UpdateAsync(StudioDetails studioDetails)
    {
        var existingDetails = await _context.StudioDetails
            .FirstOrDefaultAsync(sd => sd.StudioId == studioDetails.StudioId);

        if (existingDetails == null)
        {
            return false;
        }

        existingDetails.LicenseNumber = studioDetails.LicenseNumber;

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> DeleteAsync(int studioId)
    {
        var studioDetails = await _context.StudioDetails
            .FirstOrDefaultAsync(sd => sd.StudioId == studioId);

        if (studioDetails == null)
        {
            return false;
        }

        _context.StudioDetails.Remove(studioDetails);

        await _context.SaveChangesAsync();

        return true;
    }
}