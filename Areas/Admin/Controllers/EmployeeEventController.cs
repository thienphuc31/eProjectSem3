
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace eProject1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeEventController : Controller
    {
        private readonly DatabaseContext db;
        public EmployeeEventController(DatabaseContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var employeeEvents = db.EmployeeEvents.Include(e => e.employees).Include(e => e.events).OrderBy(e => e.status).ThenBy(e => e.EE_id).ToList();
            ViewBag.ChangedEvents = HttpContext.Session.TryGetValue("changed_events", out byte[] value)
                ? JsonConvert.DeserializeObject<Dictionary<int, bool>>(System.Text.Encoding.UTF8.GetString(value))
                : new Dictionary<int, bool>();
            return View(employeeEvents);

        }




        public IActionResult ChangeStatus(int ee_id, string action)
        {
            // get the employee event
            var employeeEvent = db.EmployeeEvents.Find(ee_id);

            if (action == "confirm")
            {
                // update status in database
                employeeEvent.status = true;
                db.SaveChanges();

                // mark event as changed in session
                var changedEvents = GetChangedEvents();
                changedEvents[ee_id] = true;
                HttpContext.Session.SetString("changed_events", JsonConvert.SerializeObject(changedEvents));
            }
            else if (action == "ignore")
            {
                // remove event from database
                db.EmployeeEvents.Remove(employeeEvent);
                db.SaveChanges();

                // remove event from session
                var changedEvents = GetChangedEvents();
                if (changedEvents.ContainsKey(ee_id))
                {
                    changedEvents.Remove(ee_id);
                    HttpContext.Session.SetString("changed_events", JsonConvert.SerializeObject(changedEvents));
                }
            }
            else
            {
                return BadRequest();
            }

            return RedirectToAction("Index");
        }

        private Dictionary<int, bool> GetChangedEvents()
        {
            var sessionData = HttpContext.Session.TryGetValue("changed_events", out byte[] value) ? System.Text.Encoding.UTF8.GetString(value) : null;
            return sessionData == null ? new Dictionary<int, bool>() : JsonConvert.DeserializeObject<Dictionary<int, bool>>(sessionData);
        }

    }
}
