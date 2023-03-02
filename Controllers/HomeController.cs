using eProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

namespace eProject1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly DatabaseContext db;
        public HomeController(ILogger<HomeController> _logger, DatabaseContext _db)
        {
            logger = _logger;
            db = _db;
        }
        public IActionResult Index()
        {
            var res = db.News.ToList();
            return View(res);
        }
        public IActionResult Details(int? id)
        {
            var news = db.News.FirstOrDefault(m => m.news_id == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }
        public IActionResult Event()
        {
            return View();
        }
        [HttpGet]


        public IActionResult FAQ()
        {
            return View();
        }
    }
}
