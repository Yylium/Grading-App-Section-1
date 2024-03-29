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
        public IActionResult Form()
        {
            ViewBag.Students = _repo.Students
                .OrderBy(x => x.first_name)
                .ToList();

            return View("Form");
        }

        [HttpPost]
        public IActionResult Form(Student_Group s)
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
