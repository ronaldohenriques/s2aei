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
    
    public partial class ComentProfessor
    {
        public System.Guid IdComentProf { get; set; }
        public System.Guid IdProjeto { get; set; }
        public string IdBloco { get; set; }
        public string IdResposta { get; set; }
    
        public virtual Professor Professor { get; set; }
        public virtual Projeto Projeto { get; set; }
    }
}
