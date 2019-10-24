using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KartinaProjet.Models
{
    public class ListArtistViewModel
    {
        public List<Artiste> ListArtist { get; set; }
        public List<Photo> FiltredPhoto { get; set; }

        public ListArtistViewModel()
        {
            ListArtist = new List<Artiste>();
            FiltredPhoto = new List<Photo>();
        }
       
    }
}