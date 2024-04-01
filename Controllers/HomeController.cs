using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Grading_App_Section_1.Controllers
{
    public class HomeController : Controller
    {
        private IGradingAppRepository _repo;

        public HomeController(IGradingAppRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
