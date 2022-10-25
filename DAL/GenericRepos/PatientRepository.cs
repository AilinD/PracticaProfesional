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
    public class PatientRepository : IGenericRepository<Paciente>
    {
        private readonly SysEntitiesContext _context;

        public PatientRepository(SysEntitiesContext context)
        {
            _context = context;
        }


        public void Delete(Paciente obj)
        {
            var r = _context.Paciente.FirstOrDefault(x => x.IdPaciente == obj.IdPaciente);
            if (r != null)
            {
                _context.Paciente.Remove(r);
                _context.SaveChanges();
            }

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
            var r = _context.Paciente.FirstOrDefault(x => x.IdPaciente == guid);

            return r;
        }

        public void Insert(Paciente obj)
        {
            _context.Paciente.Add(obj);
            _context.SaveChanges();

        }

        public void Update(Paciente obj)
        {
            var patient = _context.Paciente.FirstOrDefault(x => x.IdPaciente == obj.IdPaciente);
            if (patient != null)
            {
                patient.DNI = obj.DNI;
                patient.Nombre = obj.Nombre;
                patient.Apellido = obj.Apellido;
                patient.Contacto = obj.Contacto;
                patient.Dirección = obj.Dirección;
                patient.Sexo = obj.Sexo;
                patient.FechaNacimiento = obj.FechaNacimiento;
                _context.Update(patient);
                _context.SaveChanges();

            }







        }
    }
}
