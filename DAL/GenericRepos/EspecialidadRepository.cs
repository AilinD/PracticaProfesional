using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    public class EspecialidadRepository : IGenericRepository<Especialidad>
    {
        private readonly SysEntitiesContext _context;
        public EspecialidadRepository(SysEntitiesContext context)
        {
            _context = context;
        }
        public void Delete(Especialidad guid)
        {
            var r = _context.Especialidad.FirstOrDefault(x => x.id == guid.id);
            if (r != null)
            {
                _context.Especialidad.Remove(r);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Especialidad> GetAll(Especialidad parameters = null)
        {
            return _context.Especialidad.ToList();
        }

        public  Especialidad GetOne(int? guid)
        {
            var r = _context.Especialidad.FirstOrDefault(x => x.id == guid);

            return r;
        }

        public void Insert(Especialidad obj)
        {
            _context.Especialidad.Add(obj);
            _context.SaveChanges();
        }

        public void Update(Especialidad obj)
        {
            var especialidad = _context.Especialidad.FirstOrDefault(x => x.id == obj.id);
            if (especialidad != null)
            {
                especialidad.id = obj.id;
                especialidad.especialidad = obj.especialidad;
                _context.Update(especialidad);
                _context.SaveChanges();

            }
        }
    }
}
