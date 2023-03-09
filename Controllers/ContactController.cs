using Microsoft.AspNetCore.Http;
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
        public ActionResult Index()
        {
            // Lấy thông tin employee_id từ Session
            string employee_id = HttpContext.Session.GetString("employee_id");

            // Truy vấn các Contact có employee_id tương ứng từ CSDL
            var model = db.Contacts.Where(c => c.employee_id == employee_id).ToList();

            // Trả về view Index với danh sách các Contact đã lấy được
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
