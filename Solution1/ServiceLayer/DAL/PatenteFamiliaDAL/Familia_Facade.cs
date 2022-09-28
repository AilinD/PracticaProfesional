using ServiceLayer.DAL.Implementaciones.Adapter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Domain.PatenteFamilia;
using DataAccess.Adapter;
using Serilog;

namespace ServiceLayer.DAL.PatenteFamilia
{
	public class Familia_Facade
	{
		/// <summary>
		/// Retorna una lista de tipo familia 
		/// </summary>
		/// <returns></returns>
		public static List<Familia> GetAllAdapted()
		{
			try
			{
				ServiceLayer.DAL.Implementaciones.Adapter.FamiliaCollectionAdapter adapter = new ServiceLayer.DAL.Implementaciones.Adapter.FamiliaCollectionAdapter(SelectAll());
				List<Familia> collection = new List<Familia>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex)
			{
                Log.Error(ex, "");
                throw ex;
			}
		}

		/// <summary>
		/// Obtiene el id de una familia
		/// </summary>
		/// <param name="IdFamiliaElement"></param>
		/// <returns></returns>
		public static Familia GetAdapted(System.String IdFamiliaElement)
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
                //GestorErrores.Execute(ex);
                Log.Error(ex, "");
                throw ex;
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
                Log.Error(ex, "");
                throw ex;
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
                Log.Error(ex, "");
                throw ex;
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
                Log.Error(ex, "");
                throw ex;
			}
		}

        /// <summary>
        /// Solicita a familia_dal un select de un idfamilia
        /// </summary>
        /// <param name="IdFamiliaElement"></param>
        /// <returns></returns>
        public static DataRow Select(System.String IdFamiliaElement)
		{
			try
			{
				return Familia_dal.Select(IdFamiliaElement).Tables[0].Rows[0];
			}
			catch (Exception ex)
			{
                Log.Error(ex, "");
                throw ex;
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
                Log.Error(ex, "");
                throw ex;
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
                Log.Error(ex, "");
                throw ex;
			}
		}
	}
}
