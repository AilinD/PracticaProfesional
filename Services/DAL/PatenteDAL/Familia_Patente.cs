using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using Services.Domain;
using Microsoft.Extensions.Configuration;
using Services.BLL;

namespace Services.DAL.PatenteDAL
{
	public  class Familia_Patente
	{
		private static IConfiguration _configuration;


        Familia_Patente(IConfiguration configuration)
		{
			_configuration=configuration;
		}
       
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static DataSet SelectAll()
		{
			try
			{
				DataSet ds = new DataSet("test");
				using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("PatenteFamilia")))
				{
					SqlCommand sqlComm = new SqlCommand("Familia_Patente_SelectAll", conn);

					sqlComm.CommandType = CommandType.StoredProcedure;

					SqlDataAdapter da = new SqlDataAdapter();
					da.SelectCommand = sqlComm;
					conn.Open();
					sqlComm.ExecuteNonQuery();

					da.Fill(ds);
				}
				return ds;

			}
			catch (Exception ex)
			{
                LoggerBLL.WriteLog("SelectAll familia_patente Fallo", EventLevel.Error, "");

                throw;
			}
		}

		/// <summary>
		/// Selecciona un registro desde la tabla FamiliaElement.
		/// </summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// </history>
		public static DataSet Select(System.String IdFamiliaElement)
		{
			try
			{

				DataSet ds = new DataSet("test");
                using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("PatenteFamilia")))
                {
                    SqlCommand sqlComm = new SqlCommand("Familia_Patente_Select", conn);
					sqlComm.Parameters.AddWithValue("@IdFamilia", IdFamiliaElement);

					sqlComm.CommandType = CommandType.StoredProcedure;

					SqlDataAdapter da = new SqlDataAdapter();
					da.SelectCommand = sqlComm;
					conn.Open();
					sqlComm.ExecuteNonQuery();

					da.Fill(ds);
				}
				return ds;


				//	Database myDatabase = DatabaseFactory.CreateDatabase();
				//	DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Patente_Select");
				//	myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, IdFamiliaElement);

				//	return myDatabase.ExecuteDataSet(myCommand);
			}
			catch (Exception ex)
			{
                LoggerBLL.WriteLog("select familia_patente Fallo", EventLevel.Error, "");

                throw;
			}
		}

		/// <summary>
		/// Suprime un registro de la tabla FamiliaElement por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// </history>
		public static void Delete(FamiliaElement _object)
		{
			try
			{
                using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("PatenteFamilia")))
                {
                    SqlCommand sqlComm = new SqlCommand("Familia_Patente_Delete", conn);
                    sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);

                    sqlComm.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    conn.Open();
                    sqlComm.ExecuteNonQuery();


                }
            }
			catch (Exception ex)
			{

                LoggerBLL.WriteLog("delete familia_patente Fallo", EventLevel.Error, "");

                throw;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_object"></param>
		public static void Update(FamiliaElement _object)
		{
			try
			{
                using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("PatenteFamilia")))
                {
                    SqlCommand sqlComm = new SqlCommand("Familia_Patente_Update", conn);
					sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);
					sqlComm.Parameters.AddWithValue("@Nombre", _object.Nombre);

					sqlComm.CommandType = CommandType.StoredProcedure;

					SqlDataAdapter da = new SqlDataAdapter();
					da.SelectCommand = sqlComm;
					conn.Open();
					sqlComm.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
                LoggerBLL.WriteLog("update familia_patente Fallo", EventLevel.Error, "");

                throw;
            }
		}



		/// <summary>
		/// Inserta registros en la tabla FamiliaElement.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// </history>
		public static void Insert(FamiliaElement _object)
		{
			try
			{
                using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("PatenteFamilia")))
                {
                    SqlCommand sqlComm = new SqlCommand("Familia_Patente_Insert", conn);
					sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);
					sqlComm.Parameters.AddWithValue("@Nombre", _object.Nombre);

					sqlComm.CommandType = CommandType.StoredProcedure;

					SqlDataAdapter da = new SqlDataAdapter();
					da.SelectCommand = sqlComm;
					conn.Open();
					sqlComm.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
                LoggerBLL.WriteLog("insert familia_patente Fallo", EventLevel.Error, "");

                throw;
            }




			//Database myDatabase = DatabaseFactory.CreateDatabase();
			//DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Patente_Insert");
			//myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.IdFamiliaElement);
			//myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre);
			//myDatabase.ExecuteNonQuery(myCommand);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="IdFamiliaElement"></param>
		/// <returns></returns>
		public static DataTable GetAccesos(System.String IdFamiliaElement)
		{
			try
			{
                using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("PatenteFamilia")))
                {
                    DataTable data = new DataTable("test");
					SqlCommand sqlComm = new SqlCommand("Familia_Patente_Select", conn);
					sqlComm.Parameters.AddWithValue("@IdFamilia", IdFamiliaElement);


					sqlComm.CommandType = CommandType.StoredProcedure;

					SqlDataAdapter da = new SqlDataAdapter();
					da.SelectCommand = sqlComm;
					conn.Open();
					sqlComm.ExecuteNonQuery();
					da.Fill(data);

					return data;
				}

				//	Database myDatabase = DatabaseFactory.CreateDatabase();
				//	DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Patente_Select");
				//	myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, IdFamiliaElement);

				//	return myDatabase.ExecuteDataSet(myCommand).Tables[0];
			}
			catch (Exception ex)
			{
                LoggerBLL.WriteLog("GetAccesos Familia_patente Fallo", EventLevel.Error, "");

                throw;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_object"></param>
		public static void DeleteAccesos(Familia _object)
		{
			try
			{


                using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("PatenteFamilia")))
                {

                    SqlCommand sqlComm = new SqlCommand("Familia_Patente_Delete", conn);
					sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);


					sqlComm.CommandType = CommandType.StoredProcedure;

					SqlDataAdapter da = new SqlDataAdapter();
					da.SelectCommand = sqlComm;
					conn.Open();
					sqlComm.ExecuteNonQuery();
				}
			}catch(Exception ex)
			{
                LoggerBLL.WriteLog("DeleteAccesos Familia_patente Fallo", EventLevel.Error, "");

                throw;
            }
		}
	}
}