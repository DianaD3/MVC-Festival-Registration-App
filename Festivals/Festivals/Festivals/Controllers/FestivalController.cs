using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Festivals.DAL;
using Festivals.Models;

namespace Festivals.Controllers
{
    public class FestivalController : Controller
    {
        private FestivalContext db = new FestivalContext();

        // GET: Festival
        public ActionResult Index()
        {
            return View(db.Festival.ToList());
        }

        // GET: Festival/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Festival festival = db.Festival.Find(id);
            if (festival == null)
            {
                return HttpNotFound();
            }
            return View(festival);
        }

        // GET: Festival/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Festival/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FestivalID,NameFestival,Locatie,Start,Finish")] Festival festival)
        {
            if (ModelState.IsValid)
            {
                db.Festival.Add(festival);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(festival);
        }

        // GET: Festival/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Festival festival = db.Festival.Find(id);
            if (festival == null)
            {
                return HttpNotFound();
            }
            return View(festival);
        }

        // POST: Festival/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FestivalID,NameFestival,Locatie,Start,Finish")] Festival festival)
        {
            if (ModelState.IsValid)
            {
                db.Entry(festival).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(festival);
        }

        // GET: Festival/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Festival festival = db.Festival.Find(id);
            if (festival == null)
            {
                return HttpNotFound();
            }
            return View(festival);
        }

        // POST: Festival/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Festival festival = db.Festival.Find(id);
            db.Festival.Remove(festival);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
