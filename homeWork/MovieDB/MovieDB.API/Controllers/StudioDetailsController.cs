using Microsoft.AspNetCore.Mvc;
using MovieDB.Application.DTOs;
using MovieDB.Application.Interfaces;
using MovieDB.Domain.Entities;

namespace MovieDB.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudioDetailsController : ControllerBase
{
    private readonly IStudioDetailsRepository _studioDetailsRepository;
    private readonly IStudioRepository _studioRepository;

    public StudioDetailsController(
        IStudioDetailsRepository studioDetailsRepository,
        IStudioRepository studioRepository)
    {
        _studioDetailsRepository = studioDetailsRepository;
        _studioRepository = studioRepository;
    }

    [HttpGet("studio/{studioId:int}")]
    public async Task<ActionResult<StudioDetailsDto>> GetByStudioId(int studioId)
    {
        if (studioId <= 0)
        {
            return BadRequest("StudioId must be greater than 0.");
        }

        var studioDetails = await _studioDetailsRepository
            .GetByStudioIdAsync(studioId);

        if (studioDetails == null)
        {
            return NotFound();
        }

        var result = new StudioDetailsDto
        {
            Id = studioDetails.Id,
            LicenseNumber = studioDetails.LicenseNumber,
            StudioId = studioDetails.StudioId
        };

        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<StudioDetailsDto>> Create(StudioDetailsDto dto)
    {
        if (dto.StudioId <= 0)
        {
            return BadRequest("StudioId must be greater than 0.");
        }

        if (string.IsNullOrWhiteSpace(dto.LicenseNumber))
        {
            return BadRequest("LicenseNumber is required.");
        }

        var studio = await _studioRepository.GetByIdAsync(dto.StudioId);

        if (studio == null)
        {
            return BadRequest("Studio not found.");
        }

        var existingDetails = await _studioDetailsRepository
            .GetByStudioIdAsync(dto.StudioId);

        if (existingDetails != null)
        {
            return BadRequest("Studio already has details.");
        }

        var studioDetails = new StudioDetails
        {
            LicenseNumber = dto.LicenseNumber.Trim(),
            StudioId = dto.StudioId
        };

        var createdDetails = await _studioDetailsRepository
            .CreateAsync(studioDetails);

        var result = new StudioDetailsDto
        {
            Id = createdDetails.Id,
            LicenseNumber = createdDetails.LicenseNumber,
            StudioId = createdDetails.StudioId
        };

        return CreatedAtAction(
            nameof(GetByStudioId),
            new { studioId = result.StudioId },
            result);
    }

    [HttpPut("studio/{studioId:int}")]
    public async Task<IActionResult> Update(
        int studioId,
        StudioDetailsDto dto)
    {
        if (studioId <= 0)
        {
            return BadRequest("StudioId must be greater than 0.");
        }

        if (string.IsNullOrWhiteSpace(dto.LicenseNumber))
        {
            return BadRequest("LicenseNumber is required.");
        }

        var studio = await _studioRepository.GetByIdAsync(studioId);

        if (studio == null)
        {
            return BadRequest("Studio not found.");
        }

        var studioDetails = new StudioDetails
        {
            StudioId = studioId,
            LicenseNumber = dto.LicenseNumber.Trim()
        };

        var updated = await _studioDetailsRepository
            .UpdateAsync(studioDetails);

        if (!updated)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("studio/{studioId:int}")]
    public async Task<IActionResult> Delete(int studioId)
    {
        if (studioId <= 0)
        {
            return BadRequest("StudioId must be greater than 0.");
        }

        var deleted = await _studioDetailsRepository
            .DeleteAsync(studioId);

        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}