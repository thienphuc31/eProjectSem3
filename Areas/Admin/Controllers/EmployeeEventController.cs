using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject1.Areas.Admin.Controllers
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
        public async Task<IActionResult> Create(EmployeeEvent employeeEvent)
        {
            // your code to save employeeEvent to database

            // get the event that corresponds to the new EmployeeEvent
            Event eventToUpdate = await db.Events.FindAsync(employeeEvent.event_id);

            // get the total number of EmployeeEvents for the same event_id
            int numberOfEmployeeEvents = await db.EmployeeEvents.CountAsync(ee => ee.event_id == employeeEvent.event_id);

            // update the number property of the corresponding event
            eventToUpdate.number = numberOfEmployeeEvents;

            // save changes to the database
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        






    }
}
