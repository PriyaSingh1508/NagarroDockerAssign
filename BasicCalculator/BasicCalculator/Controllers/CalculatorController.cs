using BasicCalculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator model)
        {
            switch (model.Operation)
            {
                case "Add":
                    model.Result = model.NumberA + model.NumberB;
                    break;
                case "Subtract":
                    model.Result = model.NumberA - model.NumberB;
                    break;
                case "Multiply":
                    model.Result = model.NumberA * model.NumberB;
                    break;
                case "Divide":
                    model.Result = model.NumberA / model.NumberB;
                    break;
            }
            ViewData["Result"]=model.Result;
            return View(model);
        }
    }
}
