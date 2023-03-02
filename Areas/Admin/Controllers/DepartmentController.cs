using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
