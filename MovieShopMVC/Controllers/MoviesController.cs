using System.Threading.Tasks;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        
        // TODO: Add icons to movie details page
        // https://localhost/movies/details/id
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var movieDetails = await _movieService.GetMovieDetails(id);
            return View(movieDetails);
        }
    }
}