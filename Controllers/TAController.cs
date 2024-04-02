using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grading_App_Section_1.Controllers
{
    public class TAController : Controller
    {

        private IGradingAppRepository _repo;


        public TAController(IGradingAppRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Rubric()
        {
            //var taNetid = "hge54";
            //var classNumbers = _repo.TAs.Where(ta => ta.ta_netid == taNetid)
            //                .Select(ta => ta.class_number).FirstOrDefault();

            //var rubricItems = _repo.Rubric_Items
            //    .Where(x => x.class_number == classNumbers).ToList();
            List<Rubric_Item> rubric_Items = new List<Rubric_Item>();
            var classNumbers = 414;
            for (int i = 0; i < _repo.Rubric_Items.Count(); i++)
            {
                if (_repo.Rubric_Items[i].class_number == classNumbers)
                {
                    rubric_Items.Add(_repo.Rubric_Items[i]);
                }
            }
            //var rubricItems = _repo.Rubric_Items;

            return View(rubric_Items);
        }
    }
}
