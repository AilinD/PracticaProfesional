//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.BaseProd
{
    using System;
    using System.Collections.Generic;
    
    public partial class EstudioPaciente
    {
        public int Id { get; set; }
        public Nullable<int> IdEstudio { get; set; }
        public string Comentario { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> MatriculaMedico { get; set; }
        public Nullable<int> DNIPaciente { get; set; }
    
        public virtual Estudio Estudio { get; set; }
        public virtual Medico Medico { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
