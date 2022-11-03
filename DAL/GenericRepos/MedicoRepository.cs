using DAL.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    public class MedicoRepository : IGenericRepository<Medico>
    {
        private readonly SysEntitiesContext _context;

        public MedicoRepository(SysEntitiesContext context)
        {
            _context = context;
        }
        public void Delete(Medico obj)
        {
            var r = _context.Medico.FirstOrDefault(x => x.Id == obj.Id);
            if (r != null)
            {
                _context.Medico.Remove(r);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Medico> GetAll(Medico parameters = null)
        {
            return _context.Medico.ToList();
        }

        public Medico GetOne(int? guid)
        {
            var r = _context.Medico.FirstOrDefault(x => x.Id == guid);

            return r;
        }

        public void Insert(Medico obj)
        {
            _context.Medico.Add(obj);
            _context.SaveChanges();
        }

        public void Update(Medico obj)
        {
            var medico = _context.Medico.FirstOrDefault(x => x.Id == obj.Id);
            if (medico != null)
            {
                medico.Matricula = obj.Matricula;
                medico.Nombre = obj.Nombre;
                medico.Apellido = obj.Apellido;
                medico.Contacto = obj.Contacto;
                medico.Direccion = obj.Direccion;
                _context.Update(medico);
                _context.SaveChanges();

            }
        }
    }
}
