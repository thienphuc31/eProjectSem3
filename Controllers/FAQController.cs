using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using eProject1.Models;
using System.Net.Mail;
using MailKit;
using MailKit.Net.Smtp;

using MimeKit;

namespace eProject1.Controllers
{
    public class FAQController : Controller
    {
        private DatabaseContext db;
        public INotyfService notyfService { get; }
        public FAQController(DatabaseContext _db, INotyfService _notyfService)
        {
            db = _db;
            notyfService = _notyfService;
        }
        [HttpGet]
        public ActionResult Index()
        {
            //Feedback contactUs = db.FAQS.Find(id);
            //return View(contactUs);

            return View();
        }
        [HttpPost]
        public ActionResult Index (Feedback feedback)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    db.FAQS.Add(feedback);
                    db.SaveChanges();
                    notyfService.Success("Send email successfully");
                    return RedirectToAction("Index");

                }
                else
                {
                    ModelState.AddModelError(string.Empty, "fail");
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
