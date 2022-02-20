using Microsoft.AspNetCore.Mvc;
using PracaZaliczeniowa_MVC.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using System.Web;
using System.Net.Http;

namespace PracaZaliczeniowa_MVC.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ILogger<MoviesController> _logger;

        /*
         * Zmienna przechowująca listę filmów
        */
        static IList<MovieModel> moviesList = new List<MovieModel>{
                new MovieModel() { id = 1, room = 1, name = "Gierek", rating = 2 , start = "13:00", end = "15:00" } ,
                new MovieModel() { id = 2, room = 2, name = "Hazardzista",  rating = 3, start = "13:10", end = "15:50"  } ,
                new MovieModel() { id = 3, room = 3, cancelled = 1, name = "Babcia tu była",  rating = 3, start = "13:20", end = "15:00"   } ,
                new MovieModel() { id = 4, room = 4, name = "Zaułek koszmarów" , rating = 4, start = "13:30", end = "15:40"   } ,
                new MovieModel() { id = 5, room = 5, name = "Wszystko poszło dobrze" , rating = 5, start = "13:40", end = "14:00"},
                new MovieModel() { id = 6, room = 1, cancelled = 1, name = "Koniec" , rating = 1, start = "15:50", end = "17:00"} ,
                new MovieModel() { id = 7, room = 2, name = "Martin i magiczny las" , rating = 2, start = "19:15", end = "21:00"},
                new MovieModel() { id = 8, room = 4, name = "(Nie)długo i szczęśliwie" , rating = 2, start = "16:15", end = "17:00"},
                new MovieModel() { id = 9, room = 5, cancelled = 1, name = "355" , rating = 2, start = "19:15", end = "20:00"},
                new MovieModel() { id = 10, room = 4, name = "Krzyk" , rating = 2, start = "17:15", end = "18:00"},
                new MovieModel() { id = 11, room = 5, name = "Titane" , rating = 2, start = "13:15", end = "16:00"},
                new MovieModel() { id = 12, room = 1, name = "Koniec świata czyli Kogel Mogel 4" , rating = 2, start = "21:15", end = "22:40"},
                new MovieModel() { id = 13, room = 3, name = "Benedetta" , rating = 2, start = "22:15", end = "23:00"}
        };

        public MoviesController(ILogger<MoviesController> logger)
        {
            _logger = logger;
        }

        /**
         * Funkcja odpowiadająca za wyświetlenie strony głównej oraz przekazania
         * do widoku zmiennej moviesList która przechowuje informacje o filmach których seans 
         * odbędzie się dziś
        */
        public IActionResult Index()
        {
            return View(moviesList);
        }

        /**
         * Funkcja odpowiadająca za wyświetlenie szczegółów danego seansu
         * Może przyjąć parametr id typu int - który przechowuje id Filmu
         * W przypadku braku podania parametru program zwróci informacje o błędzie
         * z nagłówkiem 404
         * 
         * Jeżeli został podany parametr id ale nie znajduję się na liście program 
         * zwróci informacje o błędzie z nagłówkiem 404
         * 
         * Do widoku przekazywana jest zmienna z modelem danego filmu
        */
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = moviesList.FirstOrDefault(s => s.id == id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}