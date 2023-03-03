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

    }
}
