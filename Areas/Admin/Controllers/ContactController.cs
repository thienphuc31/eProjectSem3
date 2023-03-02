using Microsoft.AspNetCore.Mvc;

namespace eProject1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
