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


        public void Delete(Guid? guid)
        {
           
        }

        public IEnumerable<Paciente> GetAll(Paciente parameters = null)
        {
            return _context.Paciente.ToList();
        }

        public Paciente GetOne(Guid? guid)
        {
            _context.Paciente.FirstOrDefault();
            _context.SaveChanges();
            throw new NotImplementedException();
        }

        public void Insert(Paciente obj)
        {
            //throw new NotImp_lementedException();
        }

        public void Update(Paciente obj)
        {
            throw new NotImplementedException();
        }
    }
}
