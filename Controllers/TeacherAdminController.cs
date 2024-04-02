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

        [HttpGet]
        public IActionResult ta_index()
        {
            return View();
        }

        [HttpPost] 
        public IActionResult add_ta()
        {
            return View(ta_index);
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
            return View("rubric_Index");
        }

        // Methods to update a rubric item
        public IActionResult Edit_Rubric_Item(int id)
        {
            var rubricItem = _repo.Rubric_Items
                .Single(x => x.rubric_item_id == id);

            return View("rubric_edit_scores", rubricItem);
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
        public IActionResult Add_Rubric_Item()
        {
            return View("rubric_edit_scores", new Rubric_Item());
        }
        [HttpPost]
        public IActionResult Add_Rubric_Item(Rubric_Item addedItem)
        {
            _repo.Team7Method1(addedItem);

            return RedirectToAction("View_Rubric_Category");
        }
    }
}
