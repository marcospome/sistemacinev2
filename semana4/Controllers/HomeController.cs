using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using semana4.Models; // Aseg�rate de ajustar el espacio de nombres seg�n tu aplicaci�n
using System;
using System.Diagnostics;
using System.Linq;

namespace semana4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext; // Ajusta el nombre de TuDbContext seg�n tu aplicaci�n

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var peliculasFiltradas = _dbContext.Peliculas
                .Where(p => p.FechaDeLanzamiento > DateTime.Today)
                .ToList();

            return View(peliculasFiltradas);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
