using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grading_App_Section_1.Controllers
{
    public class StudentController : Controller
    {
        private IGradingAppRepository _repo;

        public StudentController(IGradingAppRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult LinkSubmission()
        {
            return View("LinkSubmission");
        }

        [HttpPost]
        public IActionResult LinkSubmission(Student_Group s)
        {
            if (ModelState.IsValid) 
            {
                _repo.Student_Groups.Add(s);
                return View(s);
            }
            
            return View(); 
        }
    }
}
