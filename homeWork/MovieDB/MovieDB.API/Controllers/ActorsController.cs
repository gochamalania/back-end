using Microsoft.AspNetCore.Mvc;
using MovieDB.Application.DTOs;
using MovieDB.Application.Interfaces;
using MovieDB.Domain.Entities;

namespace MovieDB.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ActorsController : ControllerBase
{
    private readonly IActorService _actorService;

    public ActorsController(IActorService actorService)
    {
        _actorService = actorService;
    }

    [HttpGet]
    public async Task<ActionResult<List<ActorDto>>> GetAll()
    {
        var actors = await _actorService.GetAllAsync();

        var result = actors.Select(a => new ActorDto
        {
            Id = a.Id,
            FirstName = a.FirstName,
            LastName = a.LastName
        }).ToList();

        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ActorDto>> GetById(int id)
    {
        if (id <= 0)
        {
            return BadRequest("Actor ID must be greater than 0.");
        }

        var actor = await _actorService.GetByIdAsync(id);

        if (actor == null)
        {
            return NotFound();
        }

        var result = new ActorDto
        {
            Id = actor.Id,
            FirstName = actor.FirstName,
            LastName = actor.LastName
        };

        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<ActorDto>> Create(ActorDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.FirstName))
        {
            return BadRequest("First name is required.");
        }

        if (dto.FirstName.Length > 100)
        {
            return BadRequest("First name cannot exceed 100 characters.");
        }

        if (string.IsNullOrWhiteSpace(dto.LastName))
        {
            return BadRequest("Last name is required.");
        }

        if (dto.LastName.Length > 100)
        {
            return BadRequest("Last name cannot exceed 100 characters.");
        }

        var actor = new Actor
        {
            FirstName = dto.FirstName.Trim(),
            LastName = dto.LastName.Trim()
        };

        var createdActor = await _actorService.CreateAsync(actor);

        var result = new ActorDto
        {
            Id = createdActor.Id,
            FirstName = createdActor.FirstName,
            LastName = createdActor.LastName
        };

        return CreatedAtAction(
            nameof(GetById),
            new { id = result.Id },
            result);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, ActorDto dto)
    {
        if (id <= 0)
        {
            return BadRequest("Actor ID must be greater than 0.");
        }

        if (string.IsNullOrWhiteSpace(dto.FirstName))
        {
            return BadRequest("First name is required.");
        }

        if (dto.FirstName.Length > 100)
        {
            return BadRequest("First name cannot exceed 100 characters.");
        }

        if (string.IsNullOrWhiteSpace(dto.LastName))
        {
            return BadRequest("Last name is required.");
        }

        if (dto.LastName.Length > 100)
        {
            return BadRequest("Last name cannot exceed 100 characters.");
        }

        var actor = new Actor
        {
            Id = id,
            FirstName = dto.FirstName.Trim(),
            LastName = dto.LastName.Trim()
        };

        var updated = await _actorService.UpdateAsync(actor);

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
            return BadRequest("Actor ID must be greater than 0.");
        }

        var deleted = await _actorService.DeleteAsync(id);

        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}