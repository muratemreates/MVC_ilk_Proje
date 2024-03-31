using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WepAppWithDatabase.Models;

namespace WepAppWithDatabase.Controllers
{
    public class OgrencilerController : Controller
    {
        // GET: Ogrenciler
        public ActionResult Index()
        {
            MyContext db = new MyContext();
            var liste = db.Ogrenciler.ToList();
            return View(liste);
        }

        public ActionResult Detay(int id)
        {
            MyContext db = new MyContext();
            var ogr = db.Ogrenciler.FirstOrDefault(x => x.Id == id);
            return View(ogr);
        }
    }
}