///////////////////////////////////////////////////////////
//  EstudioBLL.cs
//  Implementation of the Class EstudioBLL
//  Generated by Enterprise Architect
//  Created on:      18-ago.-2022 20:47:42
//  Original author: Ailin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Domain;
using DAL.Interfaces;
using BLL.Interfaces;
using Services.BLL.Dto;
using Services;
using Services.MapperConfig;

namespace BLL.Business {
	public class EstudioBLL : IGenericBusiness<EstudioDto>
    {



        private readonly static EstudioBLL _instance = new EstudioBLL();


        public static EstudioBLL Current
        {
            get
            {
                return _instance;
            }
        }

        IGenericRepository<Estudio> genericRepository = FactoryDAL._estudioRepository;

        public void Insert(EstudioDto obj)
        {
            var dtoToentity = new Estudio()
            {
                Id = obj.Id,
                Descripción = obj.Descripción

            };
            genericRepository.Insert(dtoToentity);
        }

        public void Update(EstudioDto obj)
        {
            var dtoToentity = new Estudio()
            {
                Id = obj.Id,
                Descripción = obj.Descripción

            };
            genericRepository.Update(dtoToentity);
        }

        public IEnumerable<EstudioDto> GetAll()
        {
            var entity = MapperHelper.GetMapper().
          Map<List<EstudioDto>>(genericRepository.GetAll());

            return entity;
        }

        public EstudioDto GetOne(int? guid)
        {

            var op = MapperHelper.GetMapper().Map<EstudioDto>(genericRepository.GetOne(guid));

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

        //      /// 
        //      /// <param name="estudio"></param>
        //      public Estudio AltaEstudio(Estudio estudio){

        //	return null;
        //}

        ///// 
        ///// <param name="int"></param>
        //public void BajaEstudio(int ID){

        //}

        //public List<Estudio> ListEstudio(){

        //	return null;
        //}

        ///// 
        ///// <param name="estudio"></param>
        //public void ModificacionEstudio(Estudio estudio){

        //}

    }//end EstudioBLL

}//end namespace BLL