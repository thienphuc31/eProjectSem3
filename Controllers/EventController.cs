using Microsoft.AspNetCore.Mvc;


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
            return View();
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
