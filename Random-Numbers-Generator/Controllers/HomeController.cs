using Microsoft.AspNetCore.Mvc;
using Random_Numbers_Generator.Models;
namespace Random_Numbers_Generator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RNG model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Output", new { num1 = model.Num1, num2 = model.Num2, total = model.Total });
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Output(RNG model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            else 
            { 
                return View(model);
            }
        }

        
    } // end class    
} // end namespace
