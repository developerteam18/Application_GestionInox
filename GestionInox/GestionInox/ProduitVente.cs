//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionInox
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProduitVente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProduitVente()
        {
            this.Ventes = new HashSet<Vente>();
        }
    
        public int idpv { get; set; }
        public Nullable<int> idV { get; set; }
        public Nullable<int> qte { get; set; }
        public Nullable<double> prix { get; set; }
        public Nullable<double> prixT { get; set; }
    
        public virtual Vente Vente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vente> Ventes { get; set; }
    }
}
