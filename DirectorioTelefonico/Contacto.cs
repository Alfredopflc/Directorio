//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DirectorioTelefonico
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contacto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contacto()
        {
            this.Telefono = new HashSet<Telefono>();
        }
    
        public int id_contacto { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int id_user { get; set; }
        public Nullable<System.DateTime> creation_dt { get; set; }
        public Nullable<System.TimeSpan> creation_time { get; set; }
        public string telefono { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Telefono> Telefono { get; set; }
    }
}