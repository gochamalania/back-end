
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDB.Application.Interfaces;
using MovieDB.Domain.Entities;

namespace MovieDB.API.Pages.Movies;

public class EditModel : PageModel
{
    private readonly IMovieService _movieService;
    private readonly IStudioRepository _studioRepository;

    public EditModel(
        IMovieService movieService,
        IStudioRepository studioRepository)
    {
        _movieService = movieService;
        _studioRepository = studioRepository;
    }

    [BindProperty]
    public Movie Movie { get; set; } = new();

    public async Task<IActionResult> OnGetAsync(int id)
    {
        if (id <= 0)
        {
            return BadRequest();
        }

        var movie = await _movieService.GetByIdAsync(id);

        if (movie == null)
        {
            return NotFound();
        }

        Movie = movie;

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (Movie.Id <= 0)
        {
            return BadRequest();
        }

        if (string.IsNullOrWhiteSpace(Movie.Title))
        {
            ModelState.AddModelError(
                "Movie.Title",
                "Movie title is required.");
        }
        else if (Movie.Title.Trim().Length > 150)
        {
            ModelState.AddModelError(
                "Movie.Title",
                "Title cannot exceed 150 characters.");
        }

        if (Movie.ReleaseYear <= 0)
        {
            ModelState.AddModelError(
                "Movie.ReleaseYear",
                "Release year must be greater than 0.");
        }

        if (Movie.StudioId <= 0)
        {
            ModelState.AddModelError(
                "Movie.StudioId",
                "Studio ID must be greater than 0.");
        }
        else
        {
            var studio = await _studioRepository
                .GetByIdAsync(Movie.StudioId);

            if (studio == null)
            {
                ModelState.AddModelError(
                    "Movie.StudioId",
                    "Selected studio does not exist.");
            }
        }

        if (!ModelState.IsValid)
        {
            return Page();
        }

        var updatedMovie = new Movie
        {
            Id = Movie.Id,
            Title = Movie.Title.Trim(),
            ReleaseYear = Movie.ReleaseYear,
            StudioId = Movie.StudioId
        };

        var success = await _movieService.UpdateAsync(updatedMovie);

        if (!success)
        {
            return NotFound();
        }

        return RedirectToPage(
            "/Movies/Details",
            new { id = updatedMovie.Id });
    }
}
