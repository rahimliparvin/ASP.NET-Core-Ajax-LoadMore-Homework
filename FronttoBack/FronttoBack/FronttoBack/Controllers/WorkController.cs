using Microsoft.AspNetCore.Mvc;

namespace FronttoBack.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
