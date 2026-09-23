using Microsoft.AspNetCore.Mvc;
using MovieDB.Application.DTOs;
using MovieDB.Application.Interfaces;

namespace MovieDB.API.Controllers;

[ApiController]
[Route("api/movies/{movieId:int}/actors")]
public class MovieActorsController : ControllerBase
{
    private readonly IMovieActorService _movieActorService;
    private readonly IMovieService _movieService;
    private readonly IActorService _actorService;

    public MovieActorsController(
        IMovieActorService movieActorService,
        IMovieService movieService,
        IActorService actorService)
    {
        _movieActorService = movieActorService;
        _movieService = movieService;
        _actorService = actorService;
    }

    [HttpGet]
    public async Task<ActionResult<List<ActorDto>>> GetActors(int movieId)
    {
        if (movieId <= 0)
        {
            return BadRequest("Movie ID must be greater than 0.");
        }

        var movie = await _movieService.GetByIdAsync(movieId);

        if (movie == null)
        {
            return NotFound("Movie not found.");
        }

        var actors = await _movieActorService
            .GetActorsByMovieIdAsync(movieId);

        var result = actors.Select(a => new ActorDto
        {
            Id = a.Id,
            FirstName = a.FirstName,
            LastName = a.LastName
        }).ToList();

        return Ok(result);
    }

    [HttpPost("{actorId:int}")]
    public async Task<IActionResult> AddActor(
        int movieId,
        int actorId)
    {
        if (movieId <= 0)
        {
            return BadRequest("Movie ID must be greater than 0.");
        }

        if (actorId <= 0)
        {
            return BadRequest("Actor ID must be greater than 0.");
        }

        var movie = await _movieService.GetByIdAsync(movieId);

        if (movie == null)
        {
            return NotFound("Movie not found.");
        }

        var actor = await _actorService.GetByIdAsync(actorId);

        if (actor == null)
        {
            return NotFound("Actor not found.");
        }

        var added = await _movieActorService
            .AddActorToMovieAsync(movieId, actorId);

        if (!added)
        {
            return BadRequest("Actor is already assigned to this movie.");
        }

        return NoContent();
    }

    [HttpDelete("{actorId:int}")]
    public async Task<IActionResult> RemoveActor(
        int movieId,
        int actorId)
    {
        if (movieId <= 0)
        {
            return BadRequest("Movie ID must be greater than 0.");
        }

        if (actorId <= 0)
        {
            return BadRequest("Actor ID must be greater than 0.");
        }

        var movie = await _movieService.GetByIdAsync(movieId);

        if (movie == null)
        {
            return NotFound("Movie not found.");
        }

        var actor = await _actorService.GetByIdAsync(actorId);

        if (actor == null)
        {
            return NotFound("Actor not found.");
        }

        var removed = await _movieActorService
            .RemoveActorFromMovieAsync(movieId, actorId);

        if (!removed)
        {
            return NotFound("Actor is not assigned to this movie.");
        }

        return NoContent();
    }
}