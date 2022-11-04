using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    public class EstudioRepository : IGenericRepository<Estudio>
    {
        private readonly SysEntitiesContext _context;

        public EstudioRepository(SysEntitiesContext context)
        {
            _context = context;
        }
        public void Delete(Estudio guid)
        {
            var r = _context.Estudio.FirstOrDefault(x => x.Id == guid.Id);
            if (r != null)
            {
                _context.Estudio.Remove(r);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Estudio> GetAll(Estudio parameters = null)
        {
            return _context.Estudio.ToList();
        }

        public Estudio GetOne(int? guid)
        {
            var r = _context.Estudio.FirstOrDefault(x => x.Id == guid);

            return r;
        }

        public void Insert(Estudio obj)
        {
            _context.Estudio.Add(obj);
            _context.SaveChanges();
        }

        public void Update(Estudio obj)
        {
            var estudio = _context.Estudio.FirstOrDefault(x => x.Id == obj.Id);
            if (estudio != null)
            {
                estudio.Id = obj.Id;
                estudio.Nombre = obj.Nombre;
         
                _context.Update(estudio);
                _context.SaveChanges();

            }
        }
    }
}
