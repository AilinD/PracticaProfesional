///////////////////////////////////////////////////////////
//  SintomaBLL.cs
//  Implementation of the Class SintomaBLL
//  Generated by Enterprise Architect
//  Created on:      18-ago.-2022 20:48:58
//  Original author: Ailin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using BLL;
//using Domain;
using BLL.Interfaces;
using Services.BLL.Dto;
using Services.MapperConfig;
using Services;
using DAL.Interfaces;
using DAL.Factory;
using DAL.Models;

namespace BLL.Business {
	public class SintomaBLL : IGenericBusiness<SintomaDto>
    {
        private readonly static SintomaBLL _instance = new SintomaBLL();


        public static SintomaBLL Current
        {
            get
            {
                return _instance;
            }
        }

        IGenericRepository<Sintoma> genericRepository = FactoryDAL._sintomaRepository;





        //      /// 
        //      /// <param name="sintoma"></param>
        //      public void AltaSintoma(Sintoma sintoma){

        //}

        ///// 
        ///// <param name="int"></param>
        //public void BajaSintoma(int ID){

        //}

        //public List<Sintoma> ListarSintoma(){

        //	return null;
        //}

        ///// 
        ///// <param name="sintoma"></param>
        //public void ModificarSintoma(Sintoma sintoma){

        //}

        public void Insert(SintomaDto obj)
        {
            var dtoToentity = new Sintoma()
            {
                IdSintoma = obj.IdSintoma,
                Nombre = obj.sintoma

            };
            genericRepository.Insert(dtoToentity);
        }

        public void Update(SintomaDto obj)
        {
            var dtoToentity = new Sintoma()
            {
                IdSintoma = obj.IdSintoma,
                Nombre = obj.sintoma

            };
            genericRepository.Update(dtoToentity);
        }

        public IEnumerable<SintomaDto> GetAll()
        {
            var entity = MapperHelper.GetMapper().
         Map<List<SintomaDto>>(genericRepository.GetAll());

            return entity;
        }

        public SintomaDto GetOne(int? guid)
        {
            var op = MapperHelper.GetMapper().Map<SintomaDto>(genericRepository.GetOne(guid));

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
    }//end SintomaBLL

}//end namespace BLL