using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace eProject1.Controllers
{
    public class ContactController : Controller
    {
        private DatabaseContext db;
        public ContactController(DatabaseContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
          
            string employee_id = HttpContext.Session.GetString("employee_id");

           
            var model = db.Contacts.Where(c => c.employee_id == employee_id).ToList();

           
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                contact.employee_id = HttpContext.Session.GetString("employee_id");
                contact.createdate = DateTime.Now;
                db.Contacts.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            return View(contact);
        }

    }
}
