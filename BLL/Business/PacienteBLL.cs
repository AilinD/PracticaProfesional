using BLL.Interfaces;
using DAL.Factory;
using DAL.Interfaces;
using DAL.Models;
using Services;
using BLL.Dto;
using BLL.MapperConfig;
using Services.BLL.Exepciones;

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
        try
        {
            var op = genericRepository.GetOne(guid);
            if (op != null)
            {
                genericRepository.Delete(op);
            }
        }
        catch (Exception ex)
        {
            ExceptionManager.Current.Handle(ex);

            throw;
        }
        

    }

    public IEnumerable<PacienteDto> GetAll()
    {
        try
        {
            var entity = MapperHelper.GetMapper().
            Map<List<PacienteDto>>(genericRepository.GetAll());

            return entity;
        }
        catch (Exception ex)
        {
            ExceptionManager.Current.Handle(ex);

            throw;
        }
        
    }

    public PacienteDto GetOne(int? guid)
    {
        try
        {
            var op = MapperHelper.GetMapper().Map<PacienteDto>(genericRepository.GetOne(guid));

            return op;
        }
        catch (Exception ex)
        {
            ExceptionManager.Current.Handle(ex);

            throw;
        }
        
    }

    public void Insert(PacienteDto obj)
    {
        try
        {
            var dtoToentity = new Paciente()
            {
                Dni = obj.DNI,
                Nombre = obj.Nombre,
                Apellido = obj.Apellido,
                FechaNacimiento = (DateTime)obj.FechaNacimiento,
                Dirección = obj.Dirección,
                Contacto = obj.Contacto,
                Sexo = obj.Sexo

            };
            genericRepository.Insert(dtoToentity);
        }
        catch (Exception ex)
        {
            ExceptionManager.Current.Handle(ex);

            throw;
        }
        
    }

    public async void Update(PacienteDto obj)
    {
        try
        {
            var dtoToentity = new Paciente()
            {
                IdPaciente = obj.IdPaciente,
                Dni = obj.DNI,
                Nombre = obj.Nombre,
                Apellido = obj.Apellido,
                FechaNacimiento = (DateTime)obj.FechaNacimiento,
                Dirección = obj.Dirección,
                Contacto = obj.Contacto,
                Sexo = obj.Sexo

            };
            genericRepository.Update(dtoToentity);
        }
        catch (Exception ex)
        {
            ExceptionManager.Current.Handle(ex);

            throw;
        }

}   }
