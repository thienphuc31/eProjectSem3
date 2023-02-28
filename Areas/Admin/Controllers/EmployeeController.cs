using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProject1.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore;


namespace eProject1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeController : Controller
    {
       
        private DatabaseContext db;
        public EmployeeController(DatabaseContext _db)
        {
            db = _db;
        }
        
        public IActionResult Index()
        {
            var res = db.Employees.Include(e => e.Departments).ToList();
            return View(res);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = db.Departments.ToList();
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            try
            {
                var model = db.Employees.SingleOrDefault(c => c.employee_id.Equals(employee.employee_id));
                if (model == null && ModelState.IsValid)
                {
                    db.Employees.Add(employee);
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
        public IActionResult Edit(string? id)
        {
            var model = db.Employees.Find(id);
            ViewBag.Departments = db.Departments.ToList();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee employees)
        {
            var model = db.Employees.Find(employees.employee_id);
            model.employee_password = employees.employee_password;
            model.employee_email = employees.employee_email;
            model.employee_address = employees.employee_address;
            model.employee_phone = employees.employee_phone;
            model.department_id = employees.department_id;
            db.SaveChanges();
            return RedirectToAction("Index");



        }
        [HttpGet]
        public IActionResult Delete(string? id)
        {
            var model = db.Employees.Find(id);
            db.Employees.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
