﻿using Services.Domain;
using System.Data;
using System.Diagnostics.Tracing;
using Services.BLL;

namespace Services.DAL.PatenteDAL
{
    public static class Familia_Facade
    {



        /// <summary>
        /// Retorna una lista de tipo familia 
        /// </summary>
        /// <returns></returns>
        public static List<Familia> GetAllAdapted()
        {
            try
            {
                FamiliaCollectionAdapter adapter = new FamiliaCollectionAdapter(SelectAll());
                List<Familia> collection = new List<Familia>();
                adapter.Fill(collection);
                return collection;
            }
            catch (Exception ex)
            {

                LoggerBLL.WriteLog("GetAllAdapdted Familia_Facade Fallo", EventLevel.Error, "");

            }
            return null;
        }

        /// <summary>
        /// Obtiene el id de una familia
        /// </summary>
        /// <param name="IdFamiliaElement"></param>
        /// <returns></returns>
        public static Familia GetAdapted(string IdFamiliaElement)
        {
            try
            {
                FamiliaAdapter adapter = new FamiliaAdapter(Select(IdFamiliaElement));
                Familia _object = new Familia();
                adapter.Fill(_object);
                return _object;
            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog("GetAdapted Familia_Facade Fallo", EventLevel.Error, "");

                throw;
            }
        }

        /// <summary>
        /// Solicita a Familia.dal el inserrt de un objeto de tipo familia
        /// </summary>
        /// <param name="_object"></param>
        public static void Insert(Familia _object)
        {
            try
            {
                Familia_dal.Insert(_object);
            }
            catch (Exception ex)
            {
                //GestorErrores.Execute(ex);
                LoggerBLL.WriteLog("Insert Familia_Facade Fallo", EventLevel.Error, "");

                throw;
            }
        }

        /// <summary>
        /// Solicita a familia_dal la Modificacion un registro de tipo familia
        /// </summary>
        /// <param name="_object"></param>
        public static void Update(Familia _object)
        {
            try
            {
                Familia_dal.Update(_object);
            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog("Update Familia_Facade Fallo", EventLevel.Error, "");

                throw;
            }
        }

        /// <summary>
        /// Solicita a familia_dal la eliminacion un objeto de tipo familia
        /// </summary>
        /// <param name="_object"></param>
        public static void Delete(Familia _object)
        {
            try
            {
                Familia_dal.Delete(_object);
            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog("Delete Familia_Facade Fallo", EventLevel.Error, "");

                throw;
            }
        }

        /// <summary>
        /// Solicita a familia_dal un select de un idfamilia
        /// </summary>
        /// <param name="IdFamiliaElement"></param>
        /// <returns></returns>
        public static DataRow Select(string IdFamiliaElement)
        {
            try
            {
                return Familia_dal.Select(IdFamiliaElement).Tables[0].Rows[0];
            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog("Select Familia_Facade Fallo", EventLevel.Error, "");

                throw;
            }
        }

        /// <summary>
        /// Solicita a familia_dal un select con tofos los datos de una familia
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectAll()
        {
            try
            {
                return Familia_dal.SelectAll().Tables[0];
            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog("Select_All Familia_facade Fallo", EventLevel.Error, "");

                throw;
            }
        }

        /// <summary>
        /// Solicita a familia_dal el eliminado de los accesos de una familia
        /// </summary>
        /// <param name="_object"></param>
        public static void DeleteAccesos(Familia _object)
        {
            try
            {
                Familia_dal.DeleteAccesos(_object);
            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog("DeleteAccesos Familia_Facade Fallo", EventLevel.Error, "");

                throw;
            }
        }
    }
}
