using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;
using Grading_App_Section_1.Models.ViewModels;
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
            int numGroups = 60;
            int judgesPerGroup = 2;
            int SurveyResponses = _repo.Survey_Responses.Count();

            var ItemsGraded401 = _repo.Rubric_Item_Grades
                .Join(_repo.Rubric_Items,
                    rubricGrade => rubricGrade.rubric_item_id,
                    rubricItem => rubricItem.rubric_item_id,
                    (rubricGrade, rubricItem) => new { rubricGrade, rubricItem })
                .Where(x => x.rubricItem.class_number == 401)
                .Select(x => x.rubricGrade)
                .Count();

            var ItemsGraded413 = _repo.Rubric_Item_Grades
                .Join(_repo.Rubric_Items,
                    rubricGrade => rubricGrade.rubric_item_id,
                    rubricItem => rubricItem.rubric_item_id,
                    (rubricGrade, rubricItem) => new { rubricGrade, rubricItem })
                .Where(x => x.rubricItem.class_number == 413)
                .Select(x => x.rubricGrade)
                .Count();

            var ItemsGraded414 = _repo.Rubric_Item_Grades
                .Join(_repo.Rubric_Items,
                    rubricGrade => rubricGrade.rubric_item_id,
                    rubricItem => rubricItem.rubric_item_id,
                    (rubricGrade, rubricItem) => new { rubricGrade, rubricItem })
                .Where(x => x.rubricItem.class_number == 414)
                .Select(x => x.rubricGrade)
                .Count();

            var ItemsGraded455 = _repo.Rubric_Item_Grades
                .Join(_repo.Rubric_Items,
                    rubricGrade => rubricGrade.rubric_item_id,
                    rubricItem => rubricItem.rubric_item_id,
                    (rubricGrade, rubricItem) => new { rubricGrade, rubricItem })
                .Where(x => x.rubricItem.class_number == 455)
                .Select(x => x.rubricGrade)
                .Count();

            var counts = (numGroups, judgesPerGroup, SurveyResponses, ItemsGraded401, ItemsGraded413, ItemsGraded414, ItemsGraded455);

            return View(counts);
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
            return View();
        }
        public IActionResult AddRoom()
        {
            return View();
        }
        public IActionResult JudgeDash()
        {
            var schedules = _repo.Schedules;
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
                Judges = _repo.Judges,
                Schedules = schedules,
                RoomAssignments = roomAssignments
            };

            return View(viewModel);
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
            return View();
        }
        
        public IActionResult EditJudge()
        {
            return RedirectToAction("JudgeDash");
        }
    }
}
