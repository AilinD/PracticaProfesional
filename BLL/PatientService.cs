using AutoMapper;
using BLL.Dto;
using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PatientService : IGenericBusiness<PacienteDto>
    {
        private IGenericRepository<Paciente> _repository;
        private readonly IMapper _mapper;

        public PatientService(IMapper mapper, IGenericRepository<Paciente> genericRepository)
        {
            _mapper = mapper;
            _repository = genericRepository;
        }

        public void Delete(Guid? guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PacienteDto> GetAll(PacienteDto parameters = null)
        {
            var entity= _mapper.Map<List<PacienteDto>>(_repository.GetAll());

            return entity;
        }

        public PacienteDto GetOne(Guid? guid)
        {
            throw new NotImplementedException();
        }

        public void Insert(PacienteDto obj)
        {
            throw new NotImplementedException();
        }

        public void Update(PacienteDto obj)
        {
            throw new NotImplementedException();
        }
    }
}
