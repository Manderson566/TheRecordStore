using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheRecordStore.Models;

namespace TheRecordStore.Controllers
{
    public class BandController : Controller
    {

        RecordStoreContext db = new RecordStoreContext();
        // GET: Band
        public ActionResult Index()
        {
            ViewBag.AllBands = db.Bands.OrderByDescending(b => b.Created).ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Band band)
        {
            band.Created = DateTime.Now;
            db.Bands.Add(band);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Band band = db.Bands.Find(id);
            if (band == null)
            {
                return HttpNotFound();
            }
            return View(band);
        }
    }
}
