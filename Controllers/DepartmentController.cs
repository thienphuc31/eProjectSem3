using Microsoft.AspNetCore.Mvc;

namespace eProject1.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
