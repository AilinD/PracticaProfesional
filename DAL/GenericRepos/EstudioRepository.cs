using DAL.Interfaces;
using DAL.Models;
//using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    public class EstudioRepository : IGenericRepository<Estudio>
    {
        private readonly SysCExpertContext _context;

        public EstudioRepository(SysCExpertContext context)
        {
            _context = context;
        }
        public void Delete(Estudio guid)
        {
            var r = _context.Estudios.FirstOrDefault(x => x.Id == guid.Id);
            if (r != null)
            {
                _context.Estudios.Remove(r);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Estudio> GetAll(Estudio parameters = null)
        {
            return _context.Estudios.ToList();
        }

        public Estudio GetOne(int? guid)
        {
            var r = _context.Estudios.FirstOrDefault(x => x.Id == guid);

            return r;
        }

        public void Insert(Estudio obj)
        {
            _context.Estudios.Add(obj);
            _context.SaveChanges();
        }

        public void Update(Estudio obj)
        {
            var estudio = _context.Estudios.FirstOrDefault(x => x.Id == obj.Id);
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
