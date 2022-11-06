using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Medico = DAL.Models.Medico;

namespace DAL.GenericRepos
{
    public class MedicoRepository : IGenericRepository<Medico>
    {
        private readonly SysCExpertContext _context;

        public MedicoRepository(SysCExpertContext context)
        {
            _context = context;
        }
        public void Delete(Medico obj)
        {
            var r = _context.Medicos.FirstOrDefault(x => x.IdMedico == obj.IdMedico);
            if (r != null)
            {
                _context.Medicos.Remove(r);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Medico> GetAll(Medico parameters = null)
        {
            return _context.Medicos.ToList();
        }

        public Medico GetOne(int? guid)
        {
            var r = _context.Medicos.FirstOrDefault(x => x.IdMedico == guid);

            return r;
        }

        public void Insert(Medico obj)
        {
            _context.Medicos.Add(obj);
            _context.SaveChanges();
        }

        public void Update(Medico obj)
        {
            var medico = _context.Medicos.FirstOrDefault(x => x.IdMedico == obj.IdMedico);
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
