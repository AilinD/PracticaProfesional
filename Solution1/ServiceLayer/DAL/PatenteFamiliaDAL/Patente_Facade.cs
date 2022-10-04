using Serilog;
using ServiceLayer.BLL;
using ServiceLayer.Domain.PatenteFamilia;
using ServiceLayer.Servicios.Log;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DAL.PatenteFamilia
{
	public class Patente_Facade
	{
		public static List<Patente> GetAllAdapted()
		{
			try
			{
				PatenteCollectionAdapter adapter = new PatenteCollectionAdapter(SelectAll());
				List<Patente> collection = new List<Patente>();
				adapter.Fill(collection);
				return collection;
			}
			catch (Exception ex)
			{
                  LoggerBLL.WriteLog("GetAllAdapted Patente_Facade Fallo", EventLevel.Error, "");
                throw ex;
			}
		}

		public static Patente GetAdapted(System.String IdFamiliaElement)
		{
			try
			{
				DataRow dr = Select(IdFamiliaElement);

				PatenteAdapter adapter = new PatenteAdapter(dr);

				//Instancio un objeto patente
				Patente _object = new Patente();

				adapter.Fill(_object);

				return _object;
			}
			catch (Exception ex)
			{
                  LoggerBLL.WriteLog("GetAdapted Patente_Facade Fallo", EventLevel.Error, "");
                throw ex;
			}
		}

		public static void Insert(Patente _object)
		{
			try
			{
				Patente_dal.Insert(_object);
			}
			catch (Exception ex)
			{
                  LoggerBLL.WriteLog("Insert patente_facade Fallo", EventLevel.Error, "");
                throw ex;
			}
		}

		public static void Update(Patente _object)
		{
			try
			{
				Patente_dal.Update(_object);
			}
			catch (Exception ex)
			{
                  LoggerBLL.WriteLog("Update Patente_Facade Fallo", EventLevel.Error, "");
                throw ex;
			}
		}

		public static void Delete(Patente _object)
		{
			try
			{
				Patente_dal.Delete(_object);
			}
			catch (Exception ex)
			{
                  LoggerBLL.WriteLog("Delete Patente_Facade Fallo", EventLevel.Error, "");
                throw ex;
			}
		}

		public static DataRow Select(System.String IdFamiliaElement)
		{
			try
			{
				return Patente_dal.Select(IdFamiliaElement).Tables[0].Rows[0];
			}
			catch (Exception ex)
			{
				  LoggerBLL.WriteLog("Select Patente_Facade Fallo", EventLevel.Error, "");
				throw ex;
			}
		}

		public static DataTable SelectAll()
		{
			try
			{
				return Patente_dal.SelectAll().Tables[0];
			}
			catch (Exception ex)
			{
                  LoggerBLL.WriteLog("SelectAll Patente_Facade Fallo", EventLevel.Error, "");
                throw ex;
			}
		}
	}
}
