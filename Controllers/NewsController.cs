using Microsoft.AspNetCore.Mvc;

namespace eProject1.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
