using AutoMapper;
using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using Domain;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts;
using Services;
using Services.BLL.Dto;
using Services.MapperConfig;
using System;


namespace BLL.Business;

public class PacienteBll : IGenericBusiness<PacienteDto>
{
    private readonly static PacienteBll _instance = new PacienteBll();


    public static PacienteBll Current
    {
        get
        {
            return _instance;
        }
    }


    IGenericRepository<Paciente> genericRepository = FactoryDAL._pacienteRepository;

    public void Delete(Guid? guid)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<PacienteDto> GetAll()
    {
        var entity = MapperHelper.GetMapper().
Map<List<PacienteDto>>(genericRepository.GetAll());

        return entity;
    }

    public PacienteDto GetOne(Guid? guid)
    {
        throw new NotImplementedException();
    }

    public void Insert(PacienteDto obj)
    {
        var dtoToentity= new Paciente()
        {
            Dirección=obj.Dirección
        }
    }

    public void Update(PacienteDto obj)
    {
        throw new NotImplementedException();
    }
}
