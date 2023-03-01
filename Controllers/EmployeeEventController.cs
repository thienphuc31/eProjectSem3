using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject1.Controllers
{
    public class EmployeeEventController : Controller
    {
        private DatabaseContext db;
        public EmployeeEventController(DatabaseContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(int event_id)
        {
            // Get the current employee
            var currentEmployeeId = User.Identity.Name;

            // Check if the current employee has already registered for this event
            if (db.EmployeeEvents.Any(ee => ee.event_id == event_id && ee.employee_id == currentEmployeeId))
            {
                return RedirectToAction("Index", "Home");
            }

            // Create a new EmployeeEvent with the current employee's id and the event id from the form
            var newEmployeeEvent = new EmployeeEvent
            {
                employee_id = currentEmployeeId,
                event_id = event_id,
                status = false
            };

            // Add the new EmployeeEvent to the database
            db.EmployeeEvents.Add(newEmployeeEvent);
            db.SaveChanges();
            return View();
        }
    }
}
