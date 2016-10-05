using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieBox.DAL;
using MovieBox.Models;

namespace MovieBox.Controllers
{
    public class ComingSoonController : Controller
    {
        private MovieContext db = new MovieContext();

        // GET: ComingSoon
        public ActionResult Index()
        {
            return View(db.ComingSoon.ToList());
        }

        // GET: ComingSoon/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComingSoon comingSoon = db.ComingSoon.Find(id);
            if (comingSoon == null)
            {
                return HttpNotFound();
            }
            return View(comingSoon);
        }

        // GET: ComingSoon/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ComingSoon/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Movie_ID,Title,Director,ReleaseDate,Genre")] ComingSoon comingSoon)
        {
            if (ModelState.IsValid)
            {
                db.ComingSoon.Add(comingSoon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(comingSoon);
        }

        // GET: ComingSoon/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComingSoon comingSoon = db.ComingSoon.Find(id);
            if (comingSoon == null)
            {
                return HttpNotFound();
            }
            return View(comingSoon);
        }

        // POST: ComingSoon/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Movie_ID,Title,Director,ReleaseDate,Genre")] ComingSoon comingSoon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comingSoon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(comingSoon);
        }

        // GET: ComingSoon/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComingSoon comingSoon = db.ComingSoon.Find(id);
            if (comingSoon == null)
            {
                return HttpNotFound();
            }
            return View(comingSoon);
        }

        // POST: ComingSoon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ComingSoon comingSoon = db.ComingSoon.Find(id);
            db.ComingSoon.Remove(comingSoon);
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
