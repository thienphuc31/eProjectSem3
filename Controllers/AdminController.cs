using Microsoft.AspNetCore.Mvc;

namespace eProject1.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
