using Microsoft.AspNetCore.Mvc;
using SchoolmanagementProject.Models;
using System.Diagnostics;
using DatabaseOperations.Implimentations;
using DatabaseOperations.Interface;

namespace SchoolmanagementProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISchoolService _schoolService;
        public HomeController(ILogger<HomeController> logger, ISchoolService schoolService)
        {
            _logger = logger;
            _schoolService = schoolService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AddBrancData()
        {
            _schoolService.AddData();
            return View();
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}