using DAL.Interfaces;
using DAL.Models;
//using DAL.Models;
using DAL.Repo;
//using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DAL.Models;

namespace DAL.GenericRepos
{
    public class PatientRepository : IGenericRepository<Paciente>
    {
        private readonly SysCExpertContext _context;

        public PatientRepository(SysCExpertContext context)
        {
            _context = context;
        }


        public void Delete(Paciente obj)
        {
            var r = _context.Pacientes.FirstOrDefault(x => x.IdPaciente == obj.IdPaciente);
            if (r != null)
            {
                _context.Pacientes.Remove(r);
                _context.SaveChanges();
            }

        }


        public IEnumerable<Paciente> GetAll(Paciente parameters = null)
        {
            return _context.Pacientes.ToList();
        }

        public Paciente GetOne(int? guid)
        {
            var r = _context.Pacientes.FirstOrDefault(x => x.IdPaciente == guid);

            return r;
        }

        public void Insert(Paciente obj)
        {
            _context.Pacientes.Add(obj);
            _context.SaveChanges();

        }

        public void Update(Paciente obj)
        {
            var patient = _context.Pacientes.FirstOrDefault(x => x.IdPaciente == obj.IdPaciente);
            if (patient != null)
            {
                patient.Dni = obj.Dni;
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

        public IEnumerable<ObraSocial> GetObraSocial()
        {
            return _context.ObraSocials.ToList();

        }
    }
}
