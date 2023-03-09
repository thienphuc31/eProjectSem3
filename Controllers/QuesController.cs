using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject1.Controllers
{
    public class QuesController : Controller
    {
        public DatabaseContext db { get; set; }
        public QuesController(DatabaseContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var model = db.Questions.Where(f => f.status.Equals("show")).ToList();
            return View(model);
        }
    }
}

