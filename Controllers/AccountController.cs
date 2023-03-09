using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace eProject1.Controllers
{
    public class AccountController : Controller
    {
        private DatabaseContext db;

        public AccountController(DatabaseContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string name, string pass)
        {
            try
            {
                var em = db.Employees.SingleOrDefault(a => a.employee_name.Equals(name));
                if (em != null)
                {
                    if (em.employee_password.Equals(pass))
                    {
                        HttpContext.Session.SetString("employee_name", name);
                        HttpContext.Session.SetString("employee_id", em.employee_id);

                        if (em.Role == Constants.UserType.Admin)
                        {
                            return RedirectToAction("Index", "Admin", new { area = "Admin" });
                        }
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.msg = "Password is Invalid";
                    }
                }
                else
                {
                    ViewBag.msg = "Employee Name Not Found";
                }
            }
            catch (Exception e)
            {
                ViewBag.msg = e.Message;
            }
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("employee_name") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                HttpContext.Session.Remove("employee_name");
                return RedirectToAction("Index", "Home");
            }
        }
    }
}