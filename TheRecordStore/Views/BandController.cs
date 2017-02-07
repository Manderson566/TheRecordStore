using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheRecordStore.Models;

namespace TheRecordStore.Views
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
    }
}