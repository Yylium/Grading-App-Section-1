using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Grading_App_Section_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }


   
}
