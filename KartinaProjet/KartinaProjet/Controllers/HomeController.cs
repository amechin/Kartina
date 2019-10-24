using KartinaProjet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KartinaProjet.Controllers
{
    public class HomeController : Controller
    {
        private KartinaProjetEntities db = new KartinaProjetEntities();
        public ActionResult Index()
        {
            var vm = new HomeViewModel();

            //Récupération des 6 photos les plus vendues
            vm.ListTopPhoto = db.Photo
                                .OrderByDescending(x => x.NbVentes)
                                .Take(6)
                                .ToList();

            Random rand = new Random();
            int toSkip = rand.Next(1, db.Theme.Count());
            //Récupération des 4 thèmes de manière aléatoire
            //vm.ListTheme = db.Theme
            //                .OrderBy(r => Guid.NewGuid())
            //                .Skip(toSkip).Take(4)
            //                .ToList();
            vm.ListTheme = db.Theme
                           .Take(4)
                           .ToList();

            //vm.KartinaMaj = db.KartinaMajoration
            //                        .Where(x => x.IdMajoration == 1)
            //                        .ToList()
            //                        .FirstOrDefault();


            return View(vm);
        }
    }
}