using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eProject1.Controllers
{
    public class NewsController : Controller
    {
        private DatabaseContext db;
        public NewsController(DatabaseContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var model = db.News.ToList();
            return View(model);
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
    }
}
