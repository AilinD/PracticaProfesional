using Domain;
using ServiceLayer.DAL.Adapter;
using System.Data;
using System.Diagnostics.Tracing;

namespace DAL.Patente
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
				FamiliaCollectionAdapter adapter = new FamiliaCollectionAdapter(SelectAll());
				List<Familia> collection = new List<Familia>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex)
			{
			}
			return null ;
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
                throw ex;
			}
		}
	}
}
