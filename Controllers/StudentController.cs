using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace Grading_App_Section_1.Controllers
{
    public class StudentController : Controller
    {
        private IGradingAppRepository _repo;

        public StudentController(IGradingAppRepository temp)
        {
            _repo = temp;
        }
        
        [HttpGet]
        public IActionResult LinkSubmission()
        {
            return View("~/Views/Home/Student/LinkSubmission.cshtml");
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
        
        // Build Controllers for Edit and Delete
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _repo.Student_Groups
                .Single(x => x.group_id == id);
            
            return View("~/Views/Home/Student/Edit.cshtml");
        }

        [HttpPost]
        public IActionResult Edit(Student_Group groupInfo)
        {
            if (ModelState.IsValid)
            {
                //_repo.Student_Groups.Update(groupInfo);
                return View();
            }
            
            return RedirectToAction("LinkSubmission");
        }
    }
}
