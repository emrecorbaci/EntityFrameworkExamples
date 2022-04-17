using EntityFrameworkCodeFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace EntityFrameworkCodeFirstMVC.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();

        // GET: Admin
        public ActionResult Index()
        {
            
            var data = c.Categories.ToList();
            return View(data);
        }


        [HttpGet]
        public ActionResult Add()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Add(Category category)
        {
            c.Categories.Add(category);
            c.SaveChanges();

            //return View(data);
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var data = c.Categories.Find(id);
            c.Categories.Remove(data);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data=c.Categories.Find(id);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            var data = c.Categories.Find(category.Id);
            data.Code = category.Code;
            data.Name = category.Name;
            data.Definition = category.Definition;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}