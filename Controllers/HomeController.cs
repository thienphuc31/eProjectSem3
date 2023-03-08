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
            var viewModel = new MyViewModel()
            {
                News = db.News.OrderByDescending(n => n.news_id).Take(4).ToList(),
                Events = db.Events.OrderByDescending(e => e.event_id).Take(4).ToList()
            };


            return View(viewModel);
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
