using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace eProject1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private DatabaseContext db;
        public ContactController(DatabaseContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var model = db.Contacts.Include(e => e.employees).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateAnswer(int id, string answer, int status, bool approve, bool reject)
        {
            var contact = db.Contacts.FirstOrDefault(c => c.contact_id == id);
            if (contact != null)
            {
                contact.answer = answer;
                if (approve)
                {
                    contact.status = 2;
                }
                else if (reject)
                {
                    contact.status = 3;
                }
                else
                {
                    contact.status = status;
                }
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
