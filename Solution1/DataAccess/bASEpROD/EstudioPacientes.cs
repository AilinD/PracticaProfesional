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
    
    public partial class EstudioPacientes
    {
        public int Id { get; set; }
        public Nullable<int> IdEstudio { get; set; }
        public string Comentario { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> MatriculaMedico { get; set; }
        public Nullable<int> DNIPaciente { get; set; }
        public Nullable<int> Estudio_Id { get; set; }
        public string Medico_Id { get; set; }
        public Nullable<int> Paciente_DNI { get; set; }
    
        public virtual Estudios Estudios { get; set; }
        public virtual Medicos Medicos { get; set; }
        public virtual Pacientes Pacientes { get; set; }
    }
}
