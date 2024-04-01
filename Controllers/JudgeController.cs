using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grading_App_Section_1.Controllers
{
    public class JudgeController : Controller
    {
        private EFGradingAppRepository _repo;

        public JudgeController(EFGradingAppRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index()
        {
            return null;
        }
        public IActionResult Schedule()
        {
            return null;
        }

        public IActionResult Survey()
        {
            return null;
        }

        public IActionResult Dashboard()
        {
            return null;
        }
        
        public IActionResult Rankings()
        {
            return null;
        }
        
    }
}
