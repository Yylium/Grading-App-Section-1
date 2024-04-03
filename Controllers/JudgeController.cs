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
            return View();
        }
        public IActionResult Schedule()
        {
            return View();
        }

        public IActionResult Survey(int groupId = 1)
        {
            var students = _repo.Students
                .Where(x => x.group_id == groupId).ToList();
            
            return View(students);
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
