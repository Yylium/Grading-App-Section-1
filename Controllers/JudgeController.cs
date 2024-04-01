using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grading_App_Section_1.Controllers
{
    public class JudgeController : Controller
    {
        private IGradingAppRepository _repo;

        public JudgeController(IGradingAppRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index()
        {

        }
        public IActionResult Schedule()
        {
            return View();
        }

        public IActionResult Survey()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        
        public IActionResult Rankings()
        {
            return View();
        }
        
    }
}
