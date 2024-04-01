using Microsoft.AspNetCore.Mvc;

namespace Grading_App_Section_1.Controllers
{
    public class JudgeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
