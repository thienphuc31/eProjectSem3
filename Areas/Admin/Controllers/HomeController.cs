using eProject1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProject1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private DatabaseContext db;
        public HomeController(DatabaseContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var viewModel = new MyViewModel()
            {
                News = db.News.ToList(),
                Events = db.Events.ToList(),
                Employees = db.Employees.ToList()

            };

            return View(viewModel);
        }
    }
}
