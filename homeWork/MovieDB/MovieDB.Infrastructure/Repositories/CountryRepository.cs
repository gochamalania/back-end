using Microsoft.EntityFrameworkCore;
using MovieDB.Application.Interfaces;
using MovieDB.Domain.Entities;
using MovieDB.Infrastructure.Data;

namespace MovieDB.Infrastructure.Repositories;

public class CountryRepository : ICountryRepository
{
    private readonly MovieDbContext _context;

    public CountryRepository(MovieDbContext context)
    {
        _context = context;
    }

    public async Task<List<Country>> GetAllAsync()
    {
        return await _context.Countries
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Country?> GetByIdAsync(int id)
    {
        return await _context.Countries
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<Country> CreateAsync(Country country)
    {
        _context.Countries.Add(country);

        await _context.SaveChangesAsync();

        return country;
    }

    public async Task<bool> UpdateAsync(Country country)
    {
        var existingCountry = await _context.Countries
            .FirstOrDefaultAsync(c => c.Id == country.Id);

        if (existingCountry == null)
        {
            return false;
        }

        existingCountry.Name = country.Name;

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var country = await _context.Countries
            .FirstOrDefaultAsync(c => c.Id == id);

        if (country == null)
        {
            return false;
        }

        _context.Countries.Remove(country);

        await _context.SaveChangesAsync();

        return true;
    }
}