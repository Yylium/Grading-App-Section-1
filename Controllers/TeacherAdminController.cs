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
            return View();
        }

        public IActionResult JudgeView()
        {
            return View();
        }

        public IActionResult AddJudge()
        {
            return View("~/Views/TeacherAdmin/AddJudge.cshtml");
        }
        public IActionResult AddRoom()
        {
            return View("~/Views/TeacherAdmin/AddRoom.cshtml");
        }
        public IActionResult JudgeDash()
        {
            var schedules = _repo.Schedules.ToList();
            var roomAssignments = schedules
                .GroupBy(s => s.schedule_room)
                .Select(group => new RoomAssignment
                {
                    RoomNumber = group.Key,
                    JudgesCount = group.Select(s => s.judge_team_id).Distinct().Count()
                })
                .ToList();

            var viewModel = new JudgeScheduleViewModel
            {
                Judges = _repo.Judges.ToList(),
                Schedules = schedules,
                RoomAssignments = roomAssignments
            };

            return View("~/Views/TeacherAdmin/JudgeDash.cshtml", viewModel);
        }

        public IActionResult AddSurveyItem()
        {
            return View("~/Views/TeacherAdmin/AddSurveyItem.cshtml");
        }

    }
}
