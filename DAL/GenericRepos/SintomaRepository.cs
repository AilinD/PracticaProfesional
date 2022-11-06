using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    public class SintomaRepository: IGenericRepository<Sintoma>
    {
        private readonly SysCExpertContext _context;
        public SintomaRepository(SysCExpertContext context)
        {
            _context = context;
        }
        public void Delete(Sintoma guid)
        {
            var r = _context.Sintomas.FirstOrDefault(x => x.IdSintoma == guid.IdSintoma);
            if (r != null)
            {
                _context.Sintomas.Remove(r);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Sintoma> GetAll(Sintoma parameters = null)
        {
            return _context.Sintomas.ToList();
        }

        public Sintoma GetOne(int? guid)
        {
            var r = _context.Sintomas.FirstOrDefault(x => x.IdSintoma == guid);

            return r;
        }

        public void Insert(Sintoma obj)
        {
            _context.Sintomas.Add(obj);
            _context.SaveChanges();
        }

        public void Update(Sintoma obj)
        {
            var sintoma = _context.Sintomas.FirstOrDefault(x => x.IdSintoma == obj.IdSintoma);
            if (sintoma != null)
            {
                sintoma.IdSintoma = obj.IdSintoma;
                sintoma.Nombre = obj.Nombre;
                _context.Update(sintoma);
                _context.SaveChanges();

            }
        }
    }
}
