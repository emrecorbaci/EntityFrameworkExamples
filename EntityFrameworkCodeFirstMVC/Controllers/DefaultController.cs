using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFrameworkCodeFirstMVC.Models;
using System.Data.Entity;

namespace EntityFrameworkCodeFirstMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            var c = new Context();
            var data = c.Categories.ToList();
            return View(data);
        }
    }
}