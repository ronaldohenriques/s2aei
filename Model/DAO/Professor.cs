//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Professor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Professor()
        {
            this.Participandoes = new HashSet<Participando>();
        }
    
        public System.Guid IdProfessor { get; set; }
        public string emailp { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public string disciplinaP { get; set; }
        public string departamento { get; set; }
        public byte situacao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participando> Participandoes { get; set; }
    }
}
