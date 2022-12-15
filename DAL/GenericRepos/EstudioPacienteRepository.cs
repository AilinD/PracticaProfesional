using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    internal class EstudioPacienteRepository : IGenericRepository<EstudioPaciente>
    {
        private readonly SysCExpertContext _context;
        public EstudioPacienteRepository(SysCExpertContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Elimina un registro en la tabla de EstudioPaciente
        /// </summary>
        /// <param name="guid"></param>
        public void Delete(EstudioPaciente guid)
        {
            var r = _context.EstudioPacientes.FirstOrDefault(x => x.IdPaciente == guid.IdPaciente);
            if (r != null)
            {
                _context.EstudioPacientes.Remove(r);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Obtiene todos los registros de la tabla de EstudioPaciente
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IEnumerable<EstudioPaciente> GetAll(EstudioPaciente parameters = null)
        {
            return _context.EstudioPacientes.ToList();
        }

        /// <summary>
        /// Obtiene un registro en la tabla de EstudioPaciente
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public EstudioPaciente GetOne(int? guid)
        {
            var r = _context.EstudioPacientes.FirstOrDefault(x => x.IdPaciente == guid);

            return r;
        }

        /// <summary>
        /// Inserta un registro en la tabla de EstudioPaciente
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(EstudioPaciente obj)
        {
            _context.EstudioPacientes.Add(obj);
            _context.SaveChanges();
        }

        /// <summary>
        /// Actualiza un registro en la tabla de EstudioPaciente
        /// </summary>
        /// <param name="obj"></param>
        public void Update(EstudioPaciente obj)
        {
            var estudiopaciente = _context.EstudioPacientes.FirstOrDefault(x => x.IdPaciente == obj.IdPaciente);
            if (estudiopaciente != null)
            {
                estudiopaciente.Id = obj.Id;
                estudiopaciente.IdPaciente = obj.IdPaciente;
                estudiopaciente.IdMedico = obj.IdMedico;
                estudiopaciente.IdEstudio = obj.IdEstudio;
                estudiopaciente.Fecha=obj.Fecha;
                _context.Update(estudiopaciente);
                _context.SaveChanges();

            }
        }
    }
}
