using FrontToBack.Contexts;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _dbContext;
        public HomeController(ILogger<HomeController> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var students = _dbContext.Students.ToList();
            var teachers = _dbContext.Teachers.ToList();

            return View();
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
