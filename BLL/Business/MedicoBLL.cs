///////////////////////////////////////////////////////////
//  MedicoBLL.cs
//  Implementation of the Class MedicoBLL
//  Generated by Enterprise Architect
//  Created on:      18-ago.-2022 20:48:15
//  Original author: Ailin
///////////////////////////////////////////////////////////


using Domain;
using BLL.Interfaces;
using Services;
using Services.BLL.Dto;
using DAL.Interfaces;
using Services.MapperConfig;

namespace BLL.Business {
	public class MedicoBLL : IGenericBusiness<MedicoDto>
    {

        private readonly static MedicoBLL _instance = new MedicoBLL();

        #region old
        //      /// 
        //      /// <param name="medico"></param>
        //      public void AltaMedico(Medico medico){

        //}

        ///// 
        ///// <param name="int"></param>
        //public void BajaMedico(int id){

        //}

        ///// 
        ///// <param name="matricula"></param>
        //public List<DateTime> GetDisponibilidad(int matricula){

        //	return null;
        //}

        //public List<Medico> ListarMedico<Medico>(){

        //	return null;
        //}

        ///// 
        ///// <param name="medico"></param>
        //public void ModificarMedico(Medico medico){

        //}

        //public Medico SeleccionarMedico(){

        //	return null;
        //}
        #endregion

        public static MedicoBLL Current
        {
            get
            {
                return _instance;
            }
        }


        IGenericRepository<Medico> genericRepository = FactoryDAL._medicoRepository;

        public void Insert(MedicoDto obj)
		{
            var dtoToentity = new Medico()
            {
                Matricula = obj.Matricula,
                Nombre = obj.Nombre,
                Apellido = obj.Apellido,
                Direccion = obj.Direccion,
                Contacto = obj.Contacto

            };
            genericRepository.Insert(dtoToentity);
        }

		public void Update(MedicoDto obj)
		{
            var dtoToentity = new Medico()
            {
                Matricula = obj.Matricula,
                Nombre = obj.Nombre,
                Apellido = obj.Apellido,
                Direccion = obj.Direccion,
                Contacto = obj.Contacto

            };
            genericRepository.Update(dtoToentity);
        }

		public IEnumerable<MedicoDto> GetAll()
		{
            var entity = MapperHelper.GetMapper().
           Map<List<MedicoDto>>(genericRepository.GetAll());

            return entity;
        }

		public MedicoDto GetOne(int? guid)
		{
            var op = MapperHelper.GetMapper().Map<MedicoDto>(genericRepository.GetOne(guid));

            return op;
        }

		public void Delete(int? guid)
		{
            var op = genericRepository.GetOne(guid);
            if (op != null)
            {
                genericRepository.Delete(op);
            }
        }
	}

}//end namespace BLL