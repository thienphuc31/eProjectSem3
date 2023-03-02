using Microsoft.AspNetCore.Mvc;

namespace eProject1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
