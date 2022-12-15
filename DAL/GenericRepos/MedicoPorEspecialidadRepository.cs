using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    public class MedicoPorEspecialidadRepository : IGenericRepository<MedicoPorEspecialidad>
    {
        private readonly SysCExpertContext _context;
        public MedicoPorEspecialidadRepository(SysCExpertContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Elimina un registro en la tabla de MedicoPorEspecialidad
        /// </summary>
        /// <param name="guid"></param>
        public void Delete(MedicoPorEspecialidad guid)
        {
            var r = _context.MedicoPorEspecialidads.FirstOrDefault(x => x.IdMedico == guid.IdMedico);
            if (r != null)
            {
                _context.MedicoPorEspecialidads.Remove(r);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Obtiene todos los registros de la tabla de MedicoPorEspecialidad
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IEnumerable<MedicoPorEspecialidad> GetAll(MedicoPorEspecialidad parameters = null)
        {
            return _context.MedicoPorEspecialidads.ToList();
        }

        /// <summary>
        /// Ovbtiene un registro en la tabla de MedicoPorEspecialidad
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public MedicoPorEspecialidad GetOne(int? guid)
        {
            var r = _context.MedicoPorEspecialidads.FirstOrDefault(x => x.IdMedico == guid);

            return r;
        }

        /// <summary>
        /// Inserta un registro en la tabla de MedicoPorEspecialidad
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(MedicoPorEspecialidad obj)
        {
            _context.MedicoPorEspecialidads.Add(obj);
            _context.SaveChanges();
        }

        /// <summary>
        /// Actualiza un registro en la tabla de MedicoPorEspecialidad
        /// </summary>
        /// <param name="obj"></param>
        public void Update(MedicoPorEspecialidad obj)
        {
            var medicoespecialidad = _context.MedicoPorEspecialidads.FirstOrDefault(x => x.IdMedico == obj.IdMedico);
            if (medicoespecialidad != null)
            {
                medicoespecialidad.Id = obj.Id;
                medicoespecialidad.IdMedico = obj.IdMedico;
                medicoespecialidad.IdEspecialidad = obj.IdEspecialidad;
                _context.Update(medicoespecialidad);
                _context.SaveChanges();

            }
        }
    }
}
