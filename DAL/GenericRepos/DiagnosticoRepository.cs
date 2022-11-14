using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    internal class DiagnosticoRepository : IGenericRepository<Diagnostico>
    {
        private readonly SysCExpertContext _context;
        public DiagnosticoRepository(SysCExpertContext context)
        {
            _context = context;
        }
        public void Delete(Diagnostico guid)
        {
            var r = _context.Diagnosticos.FirstOrDefault(x => x.Id == guid.Id);
            if (r != null)
            {
                _context.Diagnosticos.Remove(r);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Diagnostico> GetAll(Diagnostico parameters = null)
        {
            return _context.Diagnosticos.ToList();
        }

            public Diagnostico GetOne(int? guid)
        {
            var r = _context.Diagnosticos.FirstOrDefault(x => x.Id == guid);

            return r;
        }

        public void Insert(Diagnostico obj)
        {
            _context.Diagnosticos.Add(obj);
            _context.SaveChanges();
        }

        public void Update(Diagnostico obj)
        {
            var diagnostico = _context.Diagnosticos.FirstOrDefault(x => x.Id == obj.Id);
            if (diagnostico != null)
            {
                diagnostico.Id = obj.Id;
                diagnostico.Fecha = obj.Fecha;
                diagnostico.IdMedico = obj.IdMedico;
                diagnostico.diagnostico = obj.diagnostico;
                diagnostico.IdPaciente=obj.IdPaciente;
                _context.Update(diagnostico);
                _context.SaveChanges();

            }
        }
    }
}
