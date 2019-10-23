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

            return View();
        }
    }
}