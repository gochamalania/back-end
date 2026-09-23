using Microsoft.AspNetCore.Mvc;
using MovieDB.Application.DTOs;
using MovieDB.Application.Interfaces;
using MovieDB.Domain.Entities;

namespace MovieDB.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountriesController : ControllerBase
{
    private readonly ICountryRepository _countryRepository;

    public CountriesController(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    [HttpGet]
    public async Task<ActionResult<List<CountryDto>>> GetAll()
    {
        var countries = await _countryRepository.GetAllAsync();

        var result = countries.Select(c => new CountryDto
        {
            Id = c.Id,
            Name = c.Name
        }).ToList();

        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<CountryDto>> GetById(int id)
    {
        if (id <= 0)
        {
            return BadRequest("ID must be greater than 0.");
        }

        var country = await _countryRepository.GetByIdAsync(id);

        if (country == null)
        {
            return NotFound();
        }

        var result = new CountryDto
        {
            Id = country.Id,
            Name = country.Name
        };

        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<CountryDto>> Create(CountryDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Name))
        {
            return BadRequest("Country name is required.");
        }

        if (dto.Name.Length > 100)
        {
            return BadRequest("Country name cannot exceed 100 characters.");
        }

        var country = new Country
        {
            Name = dto.Name.Trim()
        };

        var createdCountry = await _countryRepository.CreateAsync(country);

        var result = new CountryDto
        {
            Id = createdCountry.Id,
            Name = createdCountry.Name
        };

        return CreatedAtAction(
            nameof(GetById),
            new { id = result.Id },
            result);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, CountryDto dto)
    {
        if (id <= 0)
        {
            return BadRequest("ID must be greater than 0.");
        }

        if (string.IsNullOrWhiteSpace(dto.Name))
        {
            return BadRequest("Country name is required.");
        }

        if (dto.Name.Length > 100)
        {
            return BadRequest("Country name cannot exceed 100 characters.");
        }

        var country = new Country
        {
            Id = id,
            Name = dto.Name.Trim()
        };

        var updated = await _countryRepository.UpdateAsync(country);

        if (!updated)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        if (id <= 0)
        {
            return BadRequest("ID must be greater than 0.");
        }

        var deleted = await _countryRepository.DeleteAsync(id);

        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}
