using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grading_App_Section_1.Controllers
{
    public class StudentController : Controller
    {
        private EFGradingAppRepository _repo;

        public StudentController(EFGradingAppRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index()
        {
            return null;
        }
    }
}
