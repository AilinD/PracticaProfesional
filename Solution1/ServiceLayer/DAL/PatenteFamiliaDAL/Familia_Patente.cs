using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using ServiceLayer.Domain.PatenteFamilia;
using Serilog;

namespace ServiceLayer.DAL.PatenteFamilia
{
	public class Familia_Patente
	{
		readonly static string conString;
        static Familia_Patente()
		{
			conString = ConfigurationManager.ConnectionStrings["MainConString4"].ConnectionString;
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
				using (SqlConnection conn = new SqlConnection(conString))
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
                Log.Error(ex, "");
                throw ex;
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
				using (SqlConnection conn = new SqlConnection(conString))
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
                Log.Error(ex, "");
                throw ex;
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
                using (SqlConnection conn = new SqlConnection(conString))
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
                Log.Error(ex, "");
                throw ex;
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
				using (SqlConnection conn = new SqlConnection(conString))
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
                Log.Error(ex, "");
				throw ex;
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
				using (SqlConnection conn = new SqlConnection(conString))
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
                Log.Error(ex, "");
				throw ex;
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
				using (SqlConnection conn = new SqlConnection(conString))
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
                Log.Error(ex, "");
                throw ex;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_object"></param>
		public static void DeleteAccesos(Domain.PatenteFamilia.Familia _object)
		{
			try
			{


				using (SqlConnection conn = new SqlConnection(conString))
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
                Log.Error(ex, "");
				throw ex;
            }
		}
	}
}