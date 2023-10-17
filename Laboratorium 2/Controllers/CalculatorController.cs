using Laboratorium_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_2.Controllers
{
    public enum Operators { ADD, SUB, MUL, DIV }
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Form()
        { 
            return View();
        }
        /* public IActionResult Result([FromQuery(Name = "operator")] Operators op, double? a, double? b)
         {
             if (a == null || b == null)
             {
                 return View("Error");
             }
             switch (op)
             {
                 case Operators.ADD:
                     ViewBag.result = a + b;
                     break;
                 case Operators.SUB:
                     ViewBag.result = a - b;
                     break;
                 case Operators.MUL:
                     ViewBag.result = a * b;
                     break;
                 case Operators.DIV:
                     ViewBag.result = a / b;
                     break;

             }


             return View();
         }*/
        [HttpPost]
        public IActionResult Result(Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
    }
}
