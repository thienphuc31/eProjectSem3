using Microsoft.AspNetCore.Mvc;

namespace eProject1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BellController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
