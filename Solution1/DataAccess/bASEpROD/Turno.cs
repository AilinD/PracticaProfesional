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
    
    public partial class Turno
    {
        public int Id { get; set; }
        public int DniPaciente { get; set; }
        public string Fecha { get; set; }
        public Nullable<int> MatriculaMedico { get; set; }
        public Nullable<int> IdRecepcionista { get; set; }
    
        public virtual Medico Medico { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual Recepcionista Recepcionista { get; set; }
    }
}
