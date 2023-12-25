using blogtask25thdecember.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace blogtask25thdecember.Controllers
{
    [Area("Admin")]


	public class HomeController : Controller

    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

		public ActionResult Admin()

		{
			return View();
		}

		public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Delete() 
        {
            return View();
        }

       

       
    }
}