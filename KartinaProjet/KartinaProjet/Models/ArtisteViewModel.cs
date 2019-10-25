using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartinaProjet.Models
{
    public class ArtisteViewModel
    {
        public List<Artiste> FiltredArtist { get; set; }
        public List<Photo> PhotoPresentation { get; set; }
        public List<Photo> FiltredListPhoto { get; set; }
        public ArtisteViewModel()
        {
            FiltredArtist = new List<Artiste>();
            FiltredListPhoto = new List<Photo>();
        }
    }
}