using Microsoft.AspNetCore.Mvc;
using MovieDB.Application.DTOs;
using MovieDB.Application.Interfaces;
using MovieDB.Domain.Entities;

namespace MovieDB.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudiosController : ControllerBase
{
    private readonly IStudioRepository _studioRepository;
    private readonly ICountryRepository _countryRepository;

    public StudiosController(
        IStudioRepository studioRepository,
        ICountryRepository countryRepository)
    {
        _studioRepository = studioRepository;
        _countryRepository = countryRepository;
    }

    [HttpGet]
    public async Task<ActionResult<List<StudioDto>>> GetAll()
    {
        var studios = await _studioRepository.GetAllAsync();

        var result = studios.Select(s => new StudioDto
        {
            Id = s.Id,
            Name = s.Name,
            CountryId = s.CountryId
        }).ToList();

        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<StudioDto>> GetById(int id)
    {
        if (id <= 0)
        {
            return BadRequest("ID must be greater than 0.");
        }

        var studio = await _studioRepository.GetByIdAsync(id);

        if (studio == null)
        {
            return NotFound();
        }

        var result = new StudioDto
        {
            Id = studio.Id,
            Name = studio.Name,
            CountryId = studio.CountryId
        };

        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<StudioDto>> Create(StudioDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Name))
        {
            return BadRequest("Studio name is required.");
        }

        if (dto.Name.Length > 100)
        {
            return BadRequest("Studio name cannot exceed 100 characters.");
        }

        if (dto.CountryId <= 0)
        {
            return BadRequest("CountryId must be greater than 0.");
        }

        var country = await _countryRepository.GetByIdAsync(dto.CountryId);

        if (country == null)
        {
            return BadRequest("Country not found.");
        }

        var studio = new Studio
        {
            Name = dto.Name.Trim(),
            CountryId = dto.CountryId
        };

        var createdStudio = await _studioRepository.CreateAsync(studio);

        var result = new StudioDto
        {
            Id = createdStudio.Id,
            Name = createdStudio.Name,
            CountryId = createdStudio.CountryId
        };

        return CreatedAtAction(
            nameof(GetById),
            new { id = result.Id },
            result);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, StudioDto dto)
    {
        if (id <= 0)
        {
            return BadRequest("ID must be greater than 0.");
        }

        if (string.IsNullOrWhiteSpace(dto.Name))
        {
            return BadRequest("Studio name is required.");
        }

        if (dto.Name.Length > 100)
        {
            return BadRequest("Studio name cannot exceed 100 characters.");
        }

        if (dto.CountryId <= 0)
        {
            return BadRequest("CountryId must be greater than 0.");
        }

        var country = await _countryRepository.GetByIdAsync(dto.CountryId);

        if (country == null)
        {
            return BadRequest("Country not found.");
        }

        var studio = new Studio
        {
            Id = id,
            Name = dto.Name.Trim(),
            CountryId = dto.CountryId
        };

        var updated = await _studioRepository.UpdateAsync(studio);

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

        var deleted = await _studioRepository.DeleteAsync(id);

        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}