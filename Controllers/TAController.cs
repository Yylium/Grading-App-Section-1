using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grading_App_Section_1.Controllers
{
    public class TAController : Controller
    {
        private EFGradingAppRepository _repo;

        public TAController(EFGradingAppRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index()
        {
            return null;
        }
    }
}
