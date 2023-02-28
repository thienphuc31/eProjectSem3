using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using eProject1.Models;

namespace eProject1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
       
        private DatabaseContext db;
        public NewsController(DatabaseContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var res = db.News.ToList();
            return View(res);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(News news, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (file != null)
                    {
                        var filePath = Path.Combine("wwwroot/admin/img", file.FileName);
                        var stream = new FileStream(filePath, FileMode.Create);
                        file.CopyToAsync(stream);
                        news.news_img = "img/" + file.FileName;
                        db.News.Add(news);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Fail");
                    }


                }
            }
            catch (Exception ex)
            {

                ModelState.AddModelError(string.Empty, ex.Message);
            }
            
            return View(news);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var model = db.News.Find(id);
            db.News.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            
            var news = db.News.FirstOrDefault(m => m.news_id == id);
            if (news == null)
            {
                return NotFound();
            }
            news.news_img = "img/" + news.news_img;
            return View(news);
        }


    }
}
