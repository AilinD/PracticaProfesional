using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    public class ObraSocialRepository : IGenericRepository<ObraSocial>
    {
        private readonly SysCExpertContext _context;

        public ObraSocialRepository(SysCExpertContext context)
        {
            _context = context;
        }
        public void Delete(ObraSocial guid)
        {
            var r = _context.ObraSocials.FirstOrDefault(x => x.Id == guid.Id);
            if (r != null)
            {
                _context.ObraSocials.Remove(r);
                _context.SaveChanges();
            }
        }

        public IEnumerable<ObraSocial> GetAll(ObraSocial parameters = null)
        {
            return _context.ObraSocials.ToList();
            
        }

        public ObraSocial GetOne(int? guid)
        {
            var r = _context.ObraSocials.FirstOrDefault(x => x.Id == guid);

            return r;

        }

        public void Insert(ObraSocial obj)
        {
            _context.ObraSocials.Add(obj);
            _context.SaveChanges();

        }

        public void Update(ObraSocial obj)
        {
            var obrasocial = _context.ObraSocials.FirstOrDefault(x => x.Id == obj.Id);
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
