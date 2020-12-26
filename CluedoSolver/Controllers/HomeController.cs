using CluedoSolver.Models;
using CardLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CluedoSolver.Controllers
{
    public class HomeController : Controller
    {

        //dependencies
        private ICalculator _calculator;

        public HomeController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public IActionResult Index()
        {
            string str = _calculator.Test();

            ViewBag.HelloWorld = str;

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
