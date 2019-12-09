using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Util;

namespace WebApplication1.Controllers
{
    public class NewController : Controller
    {
        Class1 db = new Class1();
        // GET: New
        public ActionResult GetToday()
        {
            IEnumerable<Book> books = db.Books;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Books = books;
            return View("Index");
        }
        public ActionResult Contacts()
        {
            IEnumerable<Contacts> contacts = db.Contacts;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Contacts = contacts;
            return View();
        }
    }
}