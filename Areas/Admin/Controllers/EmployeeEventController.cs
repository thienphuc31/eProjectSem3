using eProject1.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;

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
            var employeeEvents = db.EmployeeEvents.Include(e => e.employees).Include(e => e.events);
            ViewBag.ChangedEvents = HttpContext.Session.TryGetValue("changed_events", out byte[] value) ? JsonConvert.DeserializeObject<Dictionary<int, bool>>(System.Text.Encoding.UTF8.GetString(value)) : new Dictionary<int, bool>();
            return View(employeeEvents.ToList());
        }

        public IActionResult ChangeStatus(int ee_id, bool status)
        {
            // update status in database
            var employeeEvent = db.EmployeeEvents.Find(ee_id);
            employeeEvent.status = status;
            db.SaveChanges();

            // mark event as changed in session
            var sessionData = HttpContext.Session.TryGetValue("changed_events", out byte[] value) ? System.Text.Encoding.UTF8.GetString(value) : null;
            var changed_events = sessionData == null ? new Dictionary<int, bool>() : JsonConvert.DeserializeObject<Dictionary<int, bool>>(sessionData);
            changed_events[ee_id] = true;
            HttpContext.Session.SetString("changed_events", JsonConvert.SerializeObject(changed_events));

            return RedirectToAction("Index");
        }
    }
}
