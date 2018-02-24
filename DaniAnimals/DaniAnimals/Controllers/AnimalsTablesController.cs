using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DaniAnimals.Models;

namespace DaniAnimals.Controllers
{
    public class AnimalsTablesController : Controller
    {
        private AnimalsEntities db = new AnimalsEntities();

        // GET: AnimalsTables
        public ActionResult Index()
        {
            return View(db.AnimalsTables.ToList());
        }

        // GET: AnimalsTables/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalsTable animalsTable = db.AnimalsTables.Find(id);
            if (animalsTable == null)
            {
                return HttpNotFound();
            }
            return View(animalsTable);
        }

        // GET: AnimalsTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnimalsTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnimalId,Name,Age,Type")] AnimalsTable animalsTable)
        {
            if (ModelState.IsValid)
            {
                animalsTable.AnimalId = Guid.NewGuid();
                db.AnimalsTables.Add(animalsTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(animalsTable);
        }

        // GET: AnimalsTables/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalsTable animalsTable = db.AnimalsTables.Find(id);
            if (animalsTable == null)
            {
                return HttpNotFound();
            }
            return View(animalsTable);
        }

        // POST: AnimalsTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnimalId,Name,Age,Type")] AnimalsTable animalsTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(animalsTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(animalsTable);
        }

        // GET: AnimalsTables/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalsTable animalsTable = db.AnimalsTables.Find(id);
            if (animalsTable == null)
            {
                return HttpNotFound();
            }
            return View(animalsTable);
        }

        // POST: AnimalsTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            AnimalsTable animalsTable = db.AnimalsTables.Find(id);
            db.AnimalsTables.Remove(animalsTable);
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
