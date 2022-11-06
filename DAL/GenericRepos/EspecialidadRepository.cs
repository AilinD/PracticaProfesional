using DAL.Interfaces;
using DAL.Models;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Especialidad = DAL.Models.Especialidad;

namespace DAL.GenericRepos
{
    public class EspecialidadRepository : IGenericRepository<Especialidad>
    {
        //private readonly SysEntitiesContext _context;
        private readonly SysCExpertContext _context;
        public EspecialidadRepository(SysCExpertContext context)
        {
            _context = context;
        }
        public void Delete(Especialidad guid)
        {
            var r = _context.Especialidads.FirstOrDefault(x => x.Id == guid.Id);
            if (r != null)
            {
                _context.Especialidads.Remove(r);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Especialidad> GetAll(Especialidad parameters = null)
        {
            return _context.Especialidads.ToList();
        }

        public  Especialidad GetOne(int? guid)
        {
            var r = _context.Especialidads.FirstOrDefault(x => x.Id == guid);

            return r;
        }

        public void Insert(Especialidad obj)
        {
            _context.Especialidads.Add(obj);
            _context.SaveChanges();
        }

        public void Update(Especialidad obj)
        {
            var especialidad = _context.Especialidads.FirstOrDefault(x => x.Id == obj.Id);
            if (especialidad != null)
            {
                especialidad.Id = obj.Id;
                especialidad.Nombre = obj.Nombre;
                _context.Update(especialidad);
                _context.SaveChanges();

            }
        }
    }
}
