using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eProject1.Controllers
{
    public class EventController : Controller
    {
        private DatabaseContext db;
        public EventController(DatabaseContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var model = db.Events.ToList();
            return View(model);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }

            Event events = db.Events.Find(id);

            if (events == null)
            {
                return NotFound();
            }

            return View(events);
        }
        public IActionResult Games()
        {
            var model = db.Events.Where(e => e.event_type == 2).ToList();
            return View(model);
        }
        public IActionResult Meetings()
        {
            var model = db.Events.Where(e => e.event_type == 1).ToList();
            return View(model);
        }
        public IActionResult Competitions()
        {
            var model = db.Events.Where(e => e.event_type == 3).ToList();
            return View(model);
        }


    }
}
