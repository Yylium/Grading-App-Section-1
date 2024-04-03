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
            var netid = "ctg34";
            
            var creed = _repo.Students
                .Where(x => x.student_netid == netid)
                .FirstOrDefault();
            return View("~/Views/Home/Student/LinkSubmission.cshtml", creed);
        }

        [HttpPost]
        public IActionResult LinkSubmission(string submissionLink, int groupId)
        {
            var group = new Student_Group
            {
                group_id = groupId,
                submission_link = submissionLink
            };
            _repo.Student_Groups.Add(group);
            //_repo.SaveChanges();
            
            
            return RedirectToAction("LinkSubmission"); 
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
                return View("~/Views/Home/Student/Edit.cshtml");
            }
            
            return RedirectToAction("LinkSubmission");
        }
        [HttpGet]
        public IActionResult InfoPage(string netid)
        {
            var studentinfo = _repo.Students
                .FirstOrDefault(s => s.student_netid == netid);
            // var groupsinfo = _repo.Student_Groups.FirstOrDefault(g => g.group_id == 1);

            var groupsinfo = _repo.GetStudentGroups();

            var info = new Student
            {
                first_name = studentinfo.first_name,
                group_id = studentinfo.group_id,
                last_name = studentinfo.last_name,
                Student_Group = groupsinfo.FirstOrDefault(g => g.group_id == studentinfo.group_id),
                student_modifier = studentinfo.student_modifier,
                student_netid = studentinfo.student_netid
            };
            
            return View("~/Views/Home/Student/InfoPage.cshtml", info);
        }
    }
}
