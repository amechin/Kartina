using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KartinaProjet;
using KartinaProjet.Models;

namespace KartinaProjet.Controllers
{
    public class ArtisteController : Controller
    {
        private KartinaProjetEntities db = new KartinaProjetEntities();

        // GET: Artiste
        public ActionResult Index()
        {
            var vm = new ListArtistViewModel();

            //List Artiste
            var query = from artist in db.Artiste
                        select artist;

            vm.ListArtist = query
                            .ToList();

            //List Photo
            var query2 = from Photo in db.Photo
                         select Photo;

            vm.FiltredPhoto = query2
                                .OrderBy(x => x.IdArtiste)
                                .ToList();

           
            return View(vm);
        }





        // GET: Artiste/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Artiste artiste = db.Artiste.Find(id);

            if (artiste == null)
            {
                return HttpNotFound();
            }
            var vm = new ArtisteViewModel();


            // 1 Artiste
            var query = from Artiste in db.Artiste
                        select Artiste;

            query = query
                      .Where(x => x.IdArtiste == id);

            vm.FiltredArtist = query
                                .Take(1)
                                .ToList();


            //List Photo
            var query2 = from Photo in db.Photo
                         select Photo;
            query2 = query2
                        .Where(z => z.IdArtiste == id);

            vm.FiltredListPhoto = query2
                                    .ToList();

            // 1 Photo Presentation
            var query3 = from Photo in db.Photo
                         select Photo;
            query3 = query3
                        .Where(a => a.IdArtiste == id);
            vm.PhotoPresentation = query3
                                    .OrderBy(z => z.NbVentes)
                                    .Take(1)
                                    .ToList();

            return View(vm);
        }

        // GET: Artiste/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artiste/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdArtiste,Nom,Prenom,Pays,Presentation,Facebook,Pinterest,twitter,Pseudonyme")] Artiste artiste)
        {
            if (ModelState.IsValid)
            {
                db.Artiste.Add(artiste);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(artiste);
        }

        // GET: Artiste/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artiste artiste = db.Artiste.Find(id);
            if (artiste == null)
            {
                return HttpNotFound();
            }
            return View(artiste);
        }

        // POST: Artiste/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdArtiste,Nom,Prenom,Pays,Presentation,Facebook,Pinterest,twitter,Pseudonyme")] Artiste artiste)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artiste).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artiste);
        }

        // GET: Artiste/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artiste artiste = db.Artiste.Find(id);
            if (artiste == null)
            {
                return HttpNotFound();
            }
            return View(artiste);
        }

        // POST: Artiste/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artiste artiste = db.Artiste.Find(id);
            db.Artiste.Remove(artiste);
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
