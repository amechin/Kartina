//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KartinaProjet
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aide
    {
        public int IdAide { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public int IdSujet { get; set; }
        public string Message { get; set; }
    
        public virtual Sujet Sujet { get; set; }
    }
}