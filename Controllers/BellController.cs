using Microsoft.AspNetCore.Mvc;

namespace eProject1.Controllers
{
    public class BellController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
