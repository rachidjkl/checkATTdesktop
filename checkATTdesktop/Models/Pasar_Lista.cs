//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace checkATTdesktop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pasar_Lista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pasar_Lista()
        {
            this.Falta = new HashSet<Falta>();
        }
    
        public int id_pasar_lista { get; set; }
        public Nullable<int> id_alumno { get; set; }
        public Nullable<int> id_horario { get; set; }
        public Nullable<int> id_uf { get; set; }
        public Nullable<int> id_profe { get; set; }
        public System.DateTime id_datetime { get; set; }
        public string asistencia { get; set; }
        public bool pasada { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Falta> Falta { get; set; }
        public virtual Horario Horario { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual UF UF { get; set; }
    }
}
