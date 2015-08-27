using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MunicipalidaddelaCalera.Models;

namespace MunicipalidaddelaCalera.Controllers
{
    public class CatergoriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Catergories
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        // GET: Catergories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Catergory catergory = db.Categories.Find(id);
            if (catergory == null)
            {
                return HttpNotFound();
            }
            return View(catergory);
        }

        // GET: Catergories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Catergories/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Catergory catergory)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(catergory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(catergory);
        }

        // GET: Catergories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Catergory catergory = db.Categories.Find(id);
            if (catergory == null)
            {
                return HttpNotFound();
            }
            return View(catergory);
        }

        // POST: Catergories/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Catergory catergory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(catergory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(catergory);
        }

        // GET: Catergories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Catergory catergory = db.Categories.Find(id);
            if (catergory == null)
            {
                return HttpNotFound();
            }
            return View(catergory);
        }

        // POST: Catergories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Catergory catergory = db.Categories.Find(id);
            db.Categories.Remove(catergory);
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
