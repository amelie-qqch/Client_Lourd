//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MegaCastingModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Offre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Offre()
        {
            this.Annonceur = new HashSet<Annonceur>();
        }
    
        public long Identifiant { get; set; }
        public string Type { get; set; }
        public double Tarif { get; set; }
        public Nullable<int> Nb_Casting { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Annonceur> Annonceur { get; set; }
    }
}
