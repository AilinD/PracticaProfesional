using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PatientRepository : IGenericRepository<Paciente>
    {
        private readonly SysEntitiesContext _context;

        public PatientRepository(SysEntitiesContext context)
        {
            _context = context;
        }


        public void Delete(Paciente obj)
        {
            _context.Paciente.Remove(obj);
            _context.SaveChanges();
        }

        //public IEnumerable<Paciente> GetAll(Paciente parameters = null)
        //{
        //    return _context.Paciente.ToList();
        //}
        public IEnumerable<Paciente> GetAll(Paciente parameters = null)
        {
            return _context.Paciente.ToList();
        }

        public Paciente GetOne(int? guid)
        {
           var r =_context.Paciente.FirstOrDefault(x=>x.IdPaciente==guid);

            return r;
        }

        public void Insert(Paciente obj)
        {
            _context.Paciente.Add(obj);
            _context.SaveChanges();
            
        }

        public void Update(Paciente obj)
        {
            _context.Paciente.Update(obj);
            _context.SaveChanges();
        }
    }
}
