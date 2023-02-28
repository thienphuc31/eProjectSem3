using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProject1.Models;

namespace eProject1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DepartmentController : Controller
    {
        private DatabaseContext db;
        public DepartmentController(DatabaseContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var res = db.Departments.ToList();
            return View(res);
        }
       
    }
}
