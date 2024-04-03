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

        [HttpGet]
        public IActionResult ta_index()
        {
            var items = _repo.TAs;
            return View("ta_index", items);
        }

        [HttpPost] 
        public IActionResult add_ta()
        {
            return View("ta_index");
        }

        [HttpGet]
        public IActionResult Edit_ta(string id)
        {
            var taToEdit = _repo.TAs
                .Single(x => x.ta_netid == id);

            return View("ta_form", taToEdit);

        }

        [HttpPost]
        public IActionResult Edit_ta(TA updatedTa)
        {
            _repo.Team7Method2_2(updatedTa);
            return RedirectToAction("ta_index");
        }

        [HttpGet]
        public IActionResult Delete_ta(string id)
        {
            var taToDelete = _repo.TAs
                .Single(x => x.ta_netid == id);

            return View("ta_index");
        }

        [HttpPost]
        public IActionResult Delete_ta(TA ta_netid)
        {
            _repo.Team7Method3_2(ta_netid);
            return RedirectToAction("ta_index");
        }
        
        public IActionResult View_Rubric_Category(int category)
        {
            var categoryToDisplay = _repo.Rubric_Items
                .Where(x => x.class_number == category)
                .ToList();

            return View("rubric_class_view", categoryToDisplay);
        }

        public IActionResult View_Rubric()
        {
            var rubric = _repo.Rubric_Items;
            return View("rubric_Index", rubric);
        }

        // Methods to update a rubric item
        public IActionResult Edit_Rubric_Item(int id)
        {
            var item = _repo.Rubric_Items
                .Single(x => x.rubric_item_id == id);

            return View("rubric_edit_scores", item);
        }
        [HttpPost]
        public IActionResult Edit_Rubric_Item(Rubric_Item rubricItem)
        {
            _repo.Team7Method2(rubricItem);

            return RedirectToAction("View_Rubric_Category");
        }

        // Method to delete a rubric item
        [HttpGet]
        public IActionResult Delete_Rubric_Item(Rubric_Item rubricItem)
        {
            _repo.Team7Method3(rubricItem);

            return RedirectToAction("View_Rubric_Category");
        }

        // Methods to add a new rubric item
        [HttpGet]
        public IActionResult Add_Rubric_Item(int classNum)
        {
            var item = _repo.Rubric_Items
                .FirstOrDefault(x => x.class_number == classNum);
            
            return View("rubric_edit_scores", item);
        }
        [HttpPost]
        public IActionResult Add_Rubric_Item(Rubric_Item addedItem)
        {
            _repo.Team7Method1(addedItem);

            return RedirectToAction("View_Rubric_Category");
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
