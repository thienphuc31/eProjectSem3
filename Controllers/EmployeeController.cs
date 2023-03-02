using Microsoft.AspNetCore.Mvc;

namespace eProject1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
