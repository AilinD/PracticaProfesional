﻿using DAL;
using DAL.GenericRepos;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factory
{
    public static class FactoryDAL
    {
        public static IGenericRepository<Paciente> _pacienteRepository { get; private set; }
        public static IGenericRepository<Medico> _medicoRepository { get; private set; }
        public static IGenericRepository<Estudio> _estudioRepository { get; private set; }
        public static IGenericRepository<Sintoma> _sintomaRepository { get; private set; }
        public static IGenericRepository<Especialidad> _especialidadRepository { get; private set; }
        public static IGenericRepository<ObraSocial> _obraSocialRepository { get; private set; }
        public static IGenericRepository<Diagnostico> _diagnosticoRepository { get; private set; }




        private static SysCExpertContext _SysEntitiesContext;
        private static string connectionString = ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;




        /// <summary>
        /// 
        /// </summary>
        static FactoryDAL()
        {
            _SysEntitiesContext = new SysCExpertContext(connectionString);
            _pacienteRepository=PatientRepository();
            _medicoRepository = MedicoRepository();
            _estudioRepository = EstudioRepository();
            _sintomaRepository = SintomaRepository();
            _especialidadRepository = EspecialidadRepository();
            _obraSocialRepository = ObraSocialRepository();
            _diagnosticoRepository = DiagnosticoRepository();
        }
        private static PatientRepository PatientRepository()
        {
            return new PatientRepository(_SysEntitiesContext);
        }

        private static MedicoRepository MedicoRepository()
        {
            return new MedicoRepository(_SysEntitiesContext);
        }

        private static EstudioRepository EstudioRepository()
        {
            return new EstudioRepository(_SysEntitiesContext);
        }


        private static SintomaRepository SintomaRepository()
        {
            return new SintomaRepository(_SysEntitiesContext);
        }

        private static EspecialidadRepository EspecialidadRepository()
        {
            return new EspecialidadRepository(_SysEntitiesContext);
        }

        private static ObraSocialRepository ObraSocialRepository()
        {
            return new ObraSocialRepository(_SysEntitiesContext);
        }

        private static DiagnosticoRepository DiagnosticoRepository()
        {
            return new DiagnosticoRepository(_SysEntitiesContext);
        }
    }
}