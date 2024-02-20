using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TopTenMovies.Models;

namespace TopTenMovies.Controllers
{
    public class HomeController : Controller
    {
        MoviesContext db;
        public HomeController(MoviesContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Movie> movies = await Task.Run(() => db.Movies);
            ViewBag.Movies = movies;
            return View();
        }
    }
}
