using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace eProject1.Controllers
{
    public class ContactController : Controller
    {
        private readonly DatabaseContext db;
        public ContactController(DatabaseContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            try
            {
                var model = db.Contacts.SingleOrDefault(c => c.contact_title.Equals(contact));
                if (ModelState.IsValid)
                {
                    db.Add(contact);
                    RedirectToAction("Create");

                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Fail");
                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);

            }
            return View();
        }
    }
}
