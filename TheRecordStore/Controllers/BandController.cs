using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Band band)
        {
           
            db.Bands.Add(band);
            band.Created = DateTime.Now;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int? id)
        {            
            Band band = db.Bands.Find(id);
            return View(band);
        }

        public ActionResult Edit(int? id)
        {
            Band band = db.Bands.Find(id);
            return View(band);
        } 

        [HttpPost]
        public ActionResult Edit(Band band)
        {
            db.Entry(band).State = EntityState.Modified;
            band.Created = DateTime.Now;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)
        {
            Band band = db.Bands.Find(id);
            return View(band);
        }
        [HttpPost]
        public ActionResult Delete(Band band)
        {
            db.Entry(band).State = EntityState.Modified;
            db.Bands.Remove(band);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
