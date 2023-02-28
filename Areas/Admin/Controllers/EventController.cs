using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using eProject1.Models;

namespace eProject1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EventController : Controller
    {
        private DatabaseContext db;
        public EventController(DatabaseContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var res = db.Events.ToList();
            return View(res);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Event events, IFormFile file)
        {
            try
            {
                var model = db.Employees.SingleOrDefault(c => c.employee_name.Equals(events.event_name));
                if (model == null && ModelState.IsValid)
                {
                    db.Events.Add(events);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.msg = "Fail";
                }
            }
            catch (Exception ex)
            {
                ViewBag.msg = ex.Message;
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var model = db.Events.Find(id);
            return View(model);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit( Event events)
        {
            var model = db.Events.Find(events.event_id);
            model.status = events.status;
            db.SaveChanges();
            return RedirectToAction("Index");
            

            
        }
    }
}
