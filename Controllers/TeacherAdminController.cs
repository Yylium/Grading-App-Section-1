using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            int SurveyResponses = _repo.Survey_Responses.Count();
            return View(SurveyResponses);
        }

        public IActionResult JudgeSummary()
        {
            var data = _repo.Schedules.ToList();
            var judges = _repo.Judges.ToList();
            // var studentGroups = _repo.Student_Groups.ToList();

            var model = new Tuple<List<Schedule>, List<Judge>>(data, judges);

            return View(model);
        }

        public IActionResult JudgeView(int judge_team_id)
        {
            var data = _repo.Schedules.Include(s => s.Judge_Team)
                         // .Include(s => s.group_id)
                         .Where(s => s.judge_team_id == judge_team_id)
                         .ToList();
            var judges = _repo.Judges.ToList();
            var surveyResponses = _repo.Survey_Responses.ToList();

            var model = new Tuple<List<Schedule>, List<Judge>, List<Survey_Response>>(data, judges, surveyResponses);

            return View(model);

        }
    }
}
