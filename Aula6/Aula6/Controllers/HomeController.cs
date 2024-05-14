using Aula6.Models;
using Microsoft.AspNetCore.Mvc;
using mvc.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Aula6.Controllers
{
    public class HomeController : Controller
    {

        private IPeopleRepository _peopleRepository;

    public HomeController(IPeopleRepository repository) {
        _peopleRepository = repository;
    }

        public IActionResult Index()
        {
            ViewData["Name"] = _peopleRepository.GetNameById(2);

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
