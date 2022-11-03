using AutoMapper;
using BLL.Interfaces;
using DAL;
using DAL.GenericRepos;
using DAL.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
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

    public void Delete(int? guid)
    {
        var op = genericRepository.GetOne(guid);
        if(op!= null)
        {
            genericRepository.Delete(op);
        }

    }

    public IEnumerable<PacienteDto> GetAll()
    {
        var entity = MapperHelper.GetMapper().
            Map<List<PacienteDto>>(genericRepository.GetAll());

        return entity;
    }

    public PacienteDto GetOne(int? guid)
    {
        var op = MapperHelper.GetMapper().Map<PacienteDto>(genericRepository.GetOne(guid));
       
        return op;
    }

    public void Insert(PacienteDto obj)
    {
        var dtoToentity = new Paciente()
        {
            DNI = obj.DNI,
            Nombre=obj.Nombre,
            Apellido=obj.Apellido,
            FechaNacimiento=(DateTime)obj.FechaNacimiento,
            Dirección = obj.Dirección,
            Contacto=obj.Contacto,
            Sexo=obj.Sexo

        };
        genericRepository.Insert(dtoToentity);
    }

    public async void Update(PacienteDto obj)
    {
        var dtoToentity = new Paciente()
        {
            IdPaciente=obj.IdPaciente,
            DNI = obj.DNI,
            Nombre = obj.Nombre,
            Apellido = obj.Apellido,
            FechaNacimiento = (DateTime)obj.FechaNacimiento,
            Dirección = obj.Dirección,
            Contacto = obj.Contacto,
            Sexo = obj.Sexo

        };
        genericRepository.Update(dtoToentity);
       
    }

    //public ObraSocial GetObraSocial()
    //{
        

    //}

    //public ObraSocial OSPaciente()
    //{
    //    return new ObraSocial();
    //}
}
