//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.BaseProd
{
    using System;
    using System.Collections.Generic;
    
    public partial class Horario
    {
        public Horario()
        {
            this.HorarioProfesionals = new HashSet<HorarioProfesional>();
        }
    
        public int Id { get; set; }
        public string Horario1 { get; set; }
    
        public virtual ICollection<HorarioProfesional> HorarioProfesionals { get; set; }
    }
}
