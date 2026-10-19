using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDB.Application.Interfaces;
using MovieDB.Domain.Entities;

namespace MovieDB.API.Pages.Movies;

public class DetailsModel : PageModel
{
    private readonly IMovieService _movieService;

    public DetailsModel(IMovieService movieService)
    {
        _movieService = movieService;
    }

    public Movie? Movie { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        var movies = await _movieService.GetAllAsync();

        Movie = movies.FirstOrDefault(m => m.Id == id);

        if (Movie is null)
        {
            return NotFound();
        }

        return Page();
    }
}