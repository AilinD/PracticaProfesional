using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    public    class SintomaRepository : IGenericRepository<Sintoma>
    {
        private readonly SysEntitiesContext _context;
        public SintomaRepository(SysEntitiesContext context)
        {
            _context = context;
        }
        public void Delete(Sintoma guid)
        {
            var r = _context.Sintoma.FirstOrDefault(x => x.IdSintoma == guid.IdSintoma);
            if (r != null)
            {
                _context.Sintoma.Remove(r);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Sintoma> GetAll(Sintoma parameters = null)
        {
            return _context.Sintoma.ToList();
        }

        public Sintoma GetOne(int? guid)
        {
            var r = _context.Sintoma.FirstOrDefault(x => x.IdSintoma == guid);

            return r;
        }

        public void Insert(Sintoma obj)
        {
            _context.Sintoma.Add(obj);
            _context.SaveChanges();
        }

        public void Update(Sintoma obj)
        {
            var sintoma = _context.Sintoma.FirstOrDefault(x => x.IdSintoma == obj.IdSintoma);
            if (sintoma != null)
            {
                sintoma.IdSintoma = obj.IdSintoma;
                sintoma.sintoma = obj.sintoma;
                _context.Update(sintoma);
                _context.SaveChanges();

            }
        }
    }
}
