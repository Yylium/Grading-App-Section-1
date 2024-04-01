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
            return View("~/Views/TeacherAdmin/JudgeDash.cshtml");
        }
        public IActionResult AddSurveyItem()
        {
            return View("~/Views/TeacherAdmin/AddSurveyItem.cshtml");
        }

    }
}
