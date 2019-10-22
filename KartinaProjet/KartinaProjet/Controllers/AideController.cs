using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KartinaProjet;

namespace KartinaProjet.Controllers
{
    public class AideController : Controller
    {
        private KartinaProjetEntities1 db = new KartinaProjetEntities1();

        // GET: Aide
        public ActionResult Index()
        {
            var aide = db.Aide.Include(a => a.Sujet);
            return View(aide.ToList());
        }

        // GET: Aide/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aide aide = db.Aide.Find(id);
            if (aide == null)
            {
                return HttpNotFound();
            }
            return View(aide);
        }

        // GET: Aide/Create
        public ActionResult Create()
        {
            ViewBag.IdSujet = new SelectList(db.Sujet, "IdSujet", "Sujet1");
            return View();
        }

        // POST: Aide/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAide,Nom,Prenom,Mail,IdSujet,Message")] Aide aide)
        {
            if (ModelState.IsValid)
            {
                db.Aide.Add(aide);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdSujet = new SelectList(db.Sujet, "IdSujet", "Sujet1", aide.IdSujet);
            return View(aide);
        }

        // GET: Aide/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aide aide = db.Aide.Find(id);
            if (aide == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdSujet = new SelectList(db.Sujet, "IdSujet", "Sujet1", aide.IdSujet);
            return View(aide);
        }

        // POST: Aide/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdAide,Nom,Prenom,Mail,IdSujet,Message")] Aide aide)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aide).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdSujet = new SelectList(db.Sujet, "IdSujet", "Sujet1", aide.IdSujet);
            return View(aide);
        }

        // GET: Aide/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aide aide = db.Aide.Find(id);
            if (aide == null)
            {
                return HttpNotFound();
            }
            return View(aide);
        }

        // POST: Aide/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aide aide = db.Aide.Find(id);
            db.Aide.Remove(aide);
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
