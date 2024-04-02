using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grading_App_Section_1.Controllers
{
    public class TeacherAdminController : Controller
    {
        private IGradingAppRepository _repo;

        public TeacherAdminController(IGradingAppRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult JudgeSummary()
        {
            var data = _repo.Schedules.ToList();
            var judges = _repo.Judges.ToList();
            var student_groups = _repo.Student_Groups.ToList();

            var model = new Tuple<List<Schedule>, List<Judge>, List<Student_Group>>(data, judges, student_groups);



            return View(model);
        }

        public IActionResult JudgeView()
        {
            var data = _repo.Schedules.ToList();
            var judges = _repo.Judges.ToList();
            var surveyResponses = _repo.Survey_Responses.ToList();

            var model = new Tuple<List<Schedule>, List<Judge>, List<Survey_Response>>(data, judges, surveyResponses);

            return View(model);

        }
    }
}
