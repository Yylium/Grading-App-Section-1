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
            return View()
        }

        [HttpPost] 
        public IActionResult add_ta()
        {
            return View(ta_index);
        }

        [HttpGet]
        public IActionResult Edit_ta()
        {
/*           var taToEdit = _repo.TAs
            .Single(x => x.ta_netid == id);

            ViewBag.Categories = _repo.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();*/
            return View("ta_form", taToEdit);

        }
        [HttpPost]
        public IActionResult Edit_ta(TA updatedTa)
        {
/*            _repo.UpdateTask(updatedTa);
*/
            return RedirectToAction("ta_index");
        }

        [HttpGet]
        public IActionResult Delete_ta(int id)
        {
/*            var taToDelete = _repo.TAs
                .Single(x => x.ta_netid == id);*/

            return View("ta_confirmation", taToDelete);
        }

        [HttpPost]
        public IActionResult Delete_ta(TA ta_netid)
        {
/*            _repo.RemoveTask(task);
*/
            return RedirectToAction("ta_index");
        }

    }
}
