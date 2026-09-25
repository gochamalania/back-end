using Microsoft.AspNetCore.Mvc;
using MovieDB.Application.DTOs;
using MovieDB.Application.Interfaces;
using MovieDB.Domain.Entities;

namespace MovieDB.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    private readonly IMovieService _movieService;
    private readonly IStudioRepository _studioRepository;

    public MoviesController(
        IMovieService movieService,
        IStudioRepository studioRepository)
    {
        _movieService = movieService;
        _studioRepository = studioRepository;
    }

    [HttpGet]
    public async Task<ActionResult<List<MovieDto>>> GetAll()
    {
        var movies = await _movieService.GetAllAsync();

        var result = movies.Select(m => new MovieDto
        {
            Id = m.Id,
            Title = m.Title,
            ReleaseYear = m.ReleaseYear,
            StudioId = m.StudioId
        }).ToList();

        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<MovieDto>> GetById(int id)
    {
        if (id <= 0)
        {
            return BadRequest("Movie ID must be greater than 0.");
        }

        var movie = await _movieService.GetByIdAsync(id);

        if (movie == null)
        {
            return NotFound();
        }

        var result = new MovieDto
        {
            Id = movie.Id,
            Title = movie.Title,
            ReleaseYear = movie.ReleaseYear,
            StudioId = movie.StudioId
        };

        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<MovieDto>> Create(MovieDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Title))
        {
            return BadRequest("Movie title is required.");
        }

        if (dto.Title.Length > 150)
        {
            return BadRequest("Movie title cannot exceed 150 characters.");
        }

        if (dto.ReleaseYear <= 0)
        {
            return BadRequest("Release year must be greater than 0.");
        }

        if (dto.StudioId <= 0)
        {
            return BadRequest("StudioId must be greater than 0.");
        }

        var studio = await _studioRepository.GetByIdAsync(dto.StudioId);

        if (studio == null)
        {
            return BadRequest("Studio not found.");
        }

        var movie = new Movie
        {
            Title = dto.Title.Trim(),
            ReleaseYear = dto.ReleaseYear,
            StudioId = dto.StudioId
        };

        var createdMovie = await _movieService.CreateAsync(movie);

        var result = new MovieDto
        {
            Id = createdMovie.Id,
            Title = createdMovie.Title,
            ReleaseYear = createdMovie.ReleaseYear,
            StudioId = createdMovie.StudioId
        };

        return CreatedAtAction(
            nameof(GetById),
            new { id = result.Id },
            result);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, MovieDto dto)
    {
        if (id <= 0)
        {
            return BadRequest("Movie ID must be greater than 0.");
        }

        if (string.IsNullOrWhiteSpace(dto.Title))
        {
            return BadRequest("Movie title is required.");
        }

        if (dto.Title.Length > 150)
        {
            return BadRequest("Movie title cannot exceed 150 characters.");
        }

        if (dto.ReleaseYear <= 0)
        {
            return BadRequest("Release year must be greater than 0.");
        }

        if (dto.StudioId <= 0)
        {
            return BadRequest("StudioId must be greater than 0.");
        }

        var studio = await _studioRepository.GetByIdAsync(dto.StudioId);

        if (studio == null)
        {
            return BadRequest("Studio not found.");
        }

        var movie = new Movie
        {
            Id = id,
            Title = dto.Title.Trim(),
            ReleaseYear = dto.ReleaseYear,
            StudioId = dto.StudioId
        };

        var updated = await _movieService.UpdateAsync(movie);

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
            return BadRequest("Movie ID must be greater than 0.");
        }

        var deleted = await _movieService.DeleteAsync(id);

        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }

    // ===============================
    // დავალება 1
    // ===============================

    [HttpGet("search-by-studio")]
    public async Task<ActionResult<List<MovieDto>>> SearchByStudio(
        int year,
        string studioName,
        int minimumActorCount)
    {
        var movies = await _movieService.SearchMoviesByStudioAsync(
            year,
            studioName,
            minimumActorCount);

        var result = movies.Select(m => new MovieDto
        {
            Id = m.Id,
            Title = m.Title,
            ReleaseYear = m.ReleaseYear,
            StudioId = m.StudioId
        }).ToList();

        return Ok(result);
    }

    // ===============================
    // დავალება 2
    // ===============================

    [HttpGet("search-by-country")]
    public async Task<ActionResult<List<MovieDto>>> SearchByCountry(
        string countryName,
        int minimumYear,
        int maximumActorCount)
    {
        var movies = await _movieService.SearchMoviesByCountryAsync(
            countryName,
            minimumYear,
            maximumActorCount);

        var result = movies.Select(m => new MovieDto
        {
            Id = m.Id,
            Title = m.Title,
            ReleaseYear = m.ReleaseYear,
            StudioId = m.StudioId
        }).ToList();

        return Ok(result);
    }

    // ===============================
    // დავალება 3
    // ===============================

    [HttpGet("search-advanced")]
    public async Task<ActionResult<List<MovieDto>>> SearchAdvanced(
        int fromYear,
        int toYear,
        string countryName,
        string titleText,
        int minimumActorCount)
    {
        var movies = await _movieService.SearchMoviesAdvancedAsync(
            fromYear,
            toYear,
            countryName,
            titleText,
            minimumActorCount);

        var result = movies.Select(m => new MovieDto
        {
            Id = m.Id,
            Title = m.Title,
            ReleaseYear = m.ReleaseYear,
            StudioId = m.StudioId
        }).ToList();

        return Ok(result);
    }
}