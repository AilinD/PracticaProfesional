using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    public class ObraSocialRepository : IGenericRepository<ObraSocial>
    {
        private readonly SysEntitiesContext _context;

        public ObraSocialRepository(SysEntitiesContext context)
        {
            _context = context;
        }
        public void Delete(ObraSocial guid)
        {
            var r = _context.ObraSocial.FirstOrDefault(x => x.Id == guid.Id);
            if (r != null)
            {
                _context.ObraSocial.Remove(r);
                _context.SaveChanges();
            }
        }

        public IEnumerable<ObraSocial> GetAll(ObraSocial parameters = null)
        {
            return _context.ObraSocial.ToList();
        }

        public ObraSocial GetOne(int? guid)
        {
            var r = _context.ObraSocial.FirstOrDefault(x => x.Id == guid);

            return r;
        }

        public void Insert(ObraSocial obj)
        {
            _context.ObraSocial.Add(obj);
            _context.SaveChanges();
        }

        public void Update(ObraSocial obj)
        {
            var obrasocial = _context.ObraSocial.FirstOrDefault(x => x.Id == obj.Id);
            if (obrasocial != null)
            {
                obrasocial.Id = obj.Id;
                obrasocial.Nombre = obj.Nombre;
                _context.Update(obrasocial);
                _context.SaveChanges();

            }
        }
    }
}
