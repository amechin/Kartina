<<<<<<< HEAD
﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KartinaProjetEntities : DbContext
    {
        public KartinaProjetEntities()
            : base("name=KartinaProjetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Adresse> Adresse { get; set; }
        public virtual DbSet<Aide> Aide { get; set; }
        public virtual DbSet<Artiste> Artiste { get; set; }
        public virtual DbSet<Cadre> Cadre { get; set; }
        public virtual DbSet<Commande> Commande { get; set; }
        public virtual DbSet<Finition> Finition { get; set; }
        public virtual DbSet<Format> Format { get; set; }
        public virtual DbSet<KartinaMajoration> KartinaMajoration { get; set; }
        public virtual DbSet<NbrTirageMax> NbrTirageMax { get; set; }
        public virtual DbSet<Orientation> Orientation { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Sujet> Sujet { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Taille> Taille { get; set; }
        public virtual DbSet<Theme> Theme { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }
    }
}
=======
﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KartinaProjetEntities : DbContext
    {
        public KartinaProjetEntities()
            : base("name=KartinaProjetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Adresse> Adresse { get; set; }
        public virtual DbSet<Aide> Aide { get; set; }
        public virtual DbSet<Artiste> Artiste { get; set; }
        public virtual DbSet<Cadre> Cadre { get; set; }
        public virtual DbSet<Commande> Commande { get; set; }
        public virtual DbSet<Finition> Finition { get; set; }
        public virtual DbSet<Format> Format { get; set; }
        public virtual DbSet<KartinaMajoration> KartinaMajoration { get; set; }
        public virtual DbSet<NbrTirageMax> NbrTirageMax { get; set; }
        public virtual DbSet<Orientation> Orientation { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Sujet> Sujet { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Taille> Taille { get; set; }
        public virtual DbSet<Theme> Theme { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }
    }
}
>>>>>>> 70b3d106b9b31c8f2087d29f05253eea7d38fd06
