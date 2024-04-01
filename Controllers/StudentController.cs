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
        // Build Controllers for Edit and Delete
        [HttpGet]
        public IActionResult Edit()
        {
            
            return View("~/Views/Home/Student/Edit.cshtml");
        }

        [HttpPost]
        public IActionResult Edit(Student_Group groupInfo)
        {
            
            
            return View("~/Views/Home/Student/Edit.cshtml");
        public IActionResult Edit(Student_Group groupInfo)
        {
            
            
            return View("~/Views/Home/Student/Edit.cshtml");
        public IActionResult Edit(Student_Group groupInfo)
        {
            
            
            return View("~/Views/Home/Student/Edit.cshtml");
        public IActionResult Edit(Student_Group groupInfo)
        {
            
            
            return View("~/Views/Home/Student/Edit.cshtml");
        }

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
    }
}
