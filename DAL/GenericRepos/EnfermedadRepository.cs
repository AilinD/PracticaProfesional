using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    public class EnfermedadRepository : IGenericRepository<Enfermedad>
    {
        private readonly SysEntitiesContext _context;
        public EnfermedadRepository(SysEntitiesContext context)
        {
            _context = context;
        }
        public void Delete(Enfermedad guid)
        {
            var r = _context.Enfermedad.FirstOrDefault(x => x.ID == guid.ID);
            if (r != null)
            {
                _context.Enfermedad.Remove(r);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Enfermedad> GetAll(Enfermedad parameters = null)
        {
            return _context.Enfermedad.ToList();
        }

        public Enfermedad GetOne(int? guid)
        {
            var r = _context.Enfermedad.FirstOrDefault(x => x.ID == guid);

            return r;
        }

        public void Insert(Enfermedad obj)
        {
            _context.Enfermedad.Add(obj);
            _context.SaveChanges();
        }

        public void Update(Enfermedad obj)
        {
            var enfermedad = _context.Enfermedad.FirstOrDefault(x => x.ID == obj.ID);
            if (enfermedad != null)
            {
                enfermedad.ID = obj.ID;
                enfermedad.Descripcion = obj.Descripcion;

                _context.Update(enfermedad);
                _context.SaveChanges();

            }
        }
    }
}
