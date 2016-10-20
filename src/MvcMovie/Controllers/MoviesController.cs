using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository dbRepository)
        {
            _movieRepository = dbRepository;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _movieRepository.GetMovies());
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Add(Movie movie)
        {
            _movieRepository.Add(movie);
            int taskId = await _movieRepository.SaveChangesAsync();

            return View("Index");
        }
    }
}
