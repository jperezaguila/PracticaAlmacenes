//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticaAlmacenes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Etiqueta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Etiqueta()
        {
            this.ProductoEtiqueta = new HashSet<ProductoEtiqueta>();
        }
    
        public int idEtiqueta { get; set; }
        public string descripcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoEtiqueta> ProductoEtiqueta { get; set; }
    }
}
