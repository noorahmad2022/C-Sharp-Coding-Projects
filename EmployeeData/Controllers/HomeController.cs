using EmployeeData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeeData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string Name { get; set; }
        public void OnGet()
        {

        }

        [HttpPost]
        public IActionResult index(string name)
        {
            

            return Content($"Hello {name} !");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}