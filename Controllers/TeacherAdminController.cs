using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;
using Grading_App_Section_1.Models.ViewModels;

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

        public IActionResult JudgeDetail(int id)
        {
            var judge = _repo.Judges.FirstOrDefault(j => j.judge_id == id);
            if (judge == null)
            {
                return NotFound();
            }
            return View(judge);
        }

        public IActionResult RoomDetail(string roomNumber)
        {
            var schedulesInRoom = _repo.Schedules.Where(s => s.schedule_room == roomNumber).ToList();
            // You might also want to fetch other details related to the room
            return View(schedulesInRoom);
        }


        public IActionResult AddSurveyItem()
        {
            return View("~/Views/TeacherAdmin/AddSurveyItem.cshtml");
        }

    }
}
