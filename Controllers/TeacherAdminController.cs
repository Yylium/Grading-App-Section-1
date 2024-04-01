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
        public IActionResult Edit_ta(string id)
        {
           var taToEdit = _repo.TA
            .Single(x => x.ta_netid == id);

            return View("ta_form", taToEdit);

        }

        [HttpPost]
        public IActionResult Edit_ta(TA updatedTa)
        {
            _repo.Update(updatedTa);
            _repo.SaveChanges();
            return RedirectToAction("ta_index");
        }

        [HttpGet]
        public IActionResult Delete_ta(string id)
        {
            var taToDelete = _repo.TA
                .Single(x => x.ta_netid == id);

            return View("ta_index");
        }

        [HttpPost]
        public IActionResult Delete_ta(TA ta_netid)
        {
            _repo.TAs.Remove(ta_netid);
            _repo.SaveChanges();
            return RedirectToAction("ta_index");
        }

    }
}
