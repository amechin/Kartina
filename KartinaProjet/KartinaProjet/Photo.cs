<<<<<<< HEAD
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
    
    public partial class Photo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Photo()
        {
            this.Format = new HashSet<Format>();
            this.Tag = new HashSet<Tag>();
            this.Theme = new HashSet<Theme>();
        }
    
        public int IdPhoto { get; set; }
        public string NomPh { get; set; }
        public string LienURL { get; set; }
        public int NbTirages { get; set; }
        public int StockRestant { get; set; }
        public int NbVentes { get; set; }
        public double PrixMini { get; set; }
        public System.DateTime DateMiseEnLigne { get; set; }
        public int IdOrientation { get; set; }
        public int IdArtiste { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Artiste Artiste { get; set; }
        public virtual Orientation Orientation { get; set; }
        public virtual Photo Photo1 { get; set; }
        public virtual Photo Photo2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Format> Format { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tag> Tag { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Theme> Theme { get; set; }
    }
}
=======
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
    
    public partial class Photo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Photo()
        {
            this.Format = new HashSet<Format>();
            this.Tag = new HashSet<Tag>();
            this.Theme = new HashSet<Theme>();
        }
    
        public int IdPhoto { get; set; }
        public string NomPh { get; set; }
        public string LienURL { get; set; }
        public int NbTirages { get; set; }
        public int StockRestant { get; set; }
        public int NbVentes { get; set; }
        public double PrixMini { get; set; }
        public System.DateTime DateMiseEnLigne { get; set; }
        public int IdOrientation { get; set; }
        public int IdArtiste { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Artiste Artiste { get; set; }
        public virtual Orientation Orientation { get; set; }
        public virtual Photo Photo1 { get; set; }
        public virtual Photo Photo2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Format> Format { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tag> Tag { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Theme> Theme { get; set; }
    }
}
>>>>>>> 70b3d106b9b31c8f2087d29f05253eea7d38fd06
