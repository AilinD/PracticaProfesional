using AutoMapper;
using BLL.Interfaces;
using DAL.Interfaces;
using Domain;
using Services.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TurnoService : IGenericBusiness<TurnoDto>
    {
        private IGenericRepository<Turno> _repository;
        private readonly IMapper _mapper;

        public TurnoService(IMapper mapper, IGenericRepository<Turno> genericRepository)
        {
            _mapper = mapper;
            _repository = genericRepository;
        }

      

        //public IEnumerable<TurnoDto> GetAll(PacienteDto parameters = null)
        //{
        //    var entity = _mapper.Map<List<TurnoDto>>(_repository.GetAll());

        //    return entity;
        //}

       

        void IGenericBusiness<TurnoDto>.Insert(TurnoDto obj)
        {
            throw new NotImplementedException();
        }

        void IGenericBusiness<TurnoDto>.Update(TurnoDto obj)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TurnoDto> IGenericBusiness<TurnoDto>.GetAll()
        {
            throw new NotImplementedException();
        }

        TurnoDto IGenericBusiness<TurnoDto>.GetOne(int? guid)
        {
            throw new NotImplementedException();
        }

        void IGenericBusiness<TurnoDto>.Delete(int? guid)
        {
            throw new NotImplementedException();
        }
    }
}
