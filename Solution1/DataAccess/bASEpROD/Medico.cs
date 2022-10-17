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
    
    public partial class Medico
    {
        public Medico()
        {
            this.Diagnosticoes = new HashSet<Diagnostico>();
            this.EstudioPacientes = new HashSet<EstudioPaciente>();
            this.Guardias = new HashSet<Guardia>();
            this.HistorialPacientes = new HashSet<HistorialPaciente>();
            this.HorarioProfesionals = new HashSet<HorarioProfesional>();
            this.MedicoPorEspecialidas = new HashSet<MedicoPorEspecialida>();
            this.Turnoes = new HashSet<Turno>();
        }
    
        public string Id { get; set; }
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Nullable<int> DNI { get; set; }
        public string Direccion { get; set; }
    
        public virtual ICollection<Diagnostico> Diagnosticoes { get; set; }
        public virtual ICollection<EstudioPaciente> EstudioPacientes { get; set; }
        public virtual ICollection<Guardia> Guardias { get; set; }
        public virtual ICollection<HistorialPaciente> HistorialPacientes { get; set; }
        public virtual ICollection<HorarioProfesional> HorarioProfesionals { get; set; }
        public virtual ICollection<MedicoPorEspecialida> MedicoPorEspecialidas { get; set; }
        public virtual ICollection<Turno> Turnoes { get; set; }
    }
}
