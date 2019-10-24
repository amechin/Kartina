using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartinaProjet.Models
{
    public class HomeViewModel
    {
        public List<Photo> ListTopPhoto { get; set; }
        public List<Theme> ListTheme { get; set; }
        public KartinaMajoration KartinaMaj { get; set; }
        public HomeViewModel()
        {
            ListTopPhoto = new List<Photo>();
            ListTheme = new List<Theme>();
        }

    }
}