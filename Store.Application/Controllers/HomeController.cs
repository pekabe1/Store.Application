using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Models;

namespace Store.Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.Name = "Kacper"; // przekazywanie do widokow


            var testViewModel = new TestViewModel
            {
                Name = "Ala"
            };

            return View(testViewModel);
        }

        public IActionResult TestViewModels()
        {
            var tests = new List<TestViewModel>();
            for (int i = 0; i < 10; i++)
            {
                tests.Add(new TestViewModel { Name = "name " + i });
            }

            return View(tests);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
