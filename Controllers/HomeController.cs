using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Calculator(CalculatorViewModel model)
        {
            ModelState.Clear();
            switch (model.calculationMethod)
            {
                case CalculationMethod.Addition:
                    model.Result = model.FirstNumber + model.SecondNumber;
                    break;
                case CalculationMethod.Subtraction:
                    model.Result = model.FirstNumber - model.SecondNumber;
                    break;
                case CalculationMethod.Multiplication:
                    model.Result = model.FirstNumber * model.SecondNumber;
                    break;
                case CalculationMethod.Division:
                    model.Result = model.FirstNumber / model.SecondNumber;
                    break;
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
