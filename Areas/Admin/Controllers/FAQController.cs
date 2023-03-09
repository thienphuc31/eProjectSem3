using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProject1.Models;
using System.Net.Mail;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using AspNetCoreHero.ToastNotification.Abstractions;


using Microsoft.AspNetCore.Authorization;

using MailKit.Net.Smtp;

namespace eProject1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FAQController : Controller
    {
        private DatabaseContext db;
        public INotyfService notyfService { get; }
        public FAQController(DatabaseContext _db, INotyfService _notyfService)
        {
            db = _db;
            notyfService = _notyfService;
        }
        public IActionResult Index()
        {
            var model = db.FAQS.ToList();
            return View(model);
        }
        [HttpGet]
        public ActionResult SendEmail(int id)
        {
            Feedback contactUs = db.FAQS.Find(id);
            return View(contactUs);

        }
        [HttpPost]
        public ActionResult SendEmail(string content, string first_name, string email, int id)
        {


            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 465);
                client.Authenticate("vulamminhtuan789@gmail.com", "epgrtcpybmkveppp");

                var bodyBuilder = new BodyBuilder
                {
                    HtmlBody = $"<p>Hi, {first_name}</p><p>Thank you for asking us questions</p><p>We have reviewer your question</p><p>Our answer is {content}</p><p>Have a good day</p>",

                };

                var message = new MimeMessage
                {
                    Body = bodyBuilder.ToMessageBody(),
                };
                message.From.Add(new MailboxAddress("Mee", "vulamminhtuan789@gmail.com"));
                message.To.Add(new MailboxAddress("User", email));
                message.Subject = "Answer customer questions";
                client.Send(message);
                client.Disconnect(true);
            }
            notyfService.Success("Send email successfully");
            return RedirectToAction("Index");

        }
           // var modelCT = db.FAQS.Find(id);
         //   return RedirectToAction("SendEmail",new {id = modelCT.id });

 
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactUsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactUsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactUsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactUsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactUsController/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var contact = db.FAQS.SingleOrDefault(c => c.id.Equals(id));
            if (contact != null)
            {
                db.FAQS.Remove(contact);
                db.SaveChanges();
                notyfService.Success("Delete successfully");
                return RedirectToAction("Index");
            }
            else
            {
                return NoContent();
            }
        }

    }
}
