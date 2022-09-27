 using ServiceLayer.DAL.PatenteFamilia;
using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DAL.PatenteFamilia
{
	public class Familia_dal
	{
		readonly static string conString;

		static Familia_dal()
		{
			//conString = @"Data Source=DESKTOP-2ECCL58\SQLEXPRESS;Initial Catalog=PatenteFamilia;Integrated Security=True";
			conString = ConfigurationManager.ConnectionStrings["MainConString3"].ConnectionString;
		}
        /*
		 Data Source=DESKTOP-H0P0HUN\SQLEXPRESS
		Data Source=DESKTOP-RM3UB93\SQLEXPRESS
		*/

        public static DataSet SelectAll()
		{
			try
			{
				DataSet ds = new DataSet("test");
				using (SqlConnection conn = new SqlConnection(conString))
				{

					SqlCommand sqlComm = new SqlCommand("Familia_SelectAll", conn);

					sqlComm.CommandType = CommandType.StoredProcedure;

					SqlDataAdapter da = new SqlDataAdapter();
					da.SelectCommand = sqlComm;
					conn.Open();
					sqlComm.ExecuteNonQuery();
					da.Fill(ds);

				}
				return ds;

				//Database myDatabase = DatabaseFactory.CreateDatabase();
				//DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_SelectAll");
				//return myDatabase.ExecuteDataSet(myCommand);
			}


			catch (Exception ex)
			{

				throw ex;
			}
		}

		/// <summary>
		/// Selecciona un registro desde la tabla Familia.
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

					SqlCommand sqlComm = new SqlCommand("Familia_Select", conn);
					sqlComm.Parameters.AddWithValue("@IdFamilia", IdFamiliaElement);

					sqlComm.CommandType = CommandType.StoredProcedure;

					SqlDataAdapter da = new SqlDataAdapter();
					da.SelectCommand = sqlComm;
					conn.Open();
					sqlComm.ExecuteNonQuery();


					da.Fill(ds);
					conn.Close();
				}
				return ds;





				////	Database myDatabase = DatabaseFactory.CreateDatabase();
				////	DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Select");
				//myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, IdFamiliaElement);

				//	return myDatabase.ExecuteDataSet(myCommand);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Suprime un registro de la tabla Familia por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// </history>
		public static void Delete(ServiceLayer.Domain.PatenteFamilia.Familia _object)
		{
			if (_object.Accesos != null)
				DeleteAccesos(_object);

			using (SqlConnection conn = new SqlConnection("conString"))
			{

				SqlCommand sqlComm = new SqlCommand("Familia_Delete", conn);
				sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);

				sqlComm.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter da = new SqlDataAdapter();
				da.SelectCommand = sqlComm;
				conn.Open();
				sqlComm.ExecuteNonQuery();
				conn.Close();




				//Database myDatabase = DatabaseFactory.CreateDatabase();
				//DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Delete");
				//myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.IdFamiliaElement);

				//myDatabase.ExecuteNonQuery(myCommand);
			}
		}

		/// <summary>
		/// Actualiza registros de la tabla Familia.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// </history>
		public static void Update(ServiceLayer.Domain.PatenteFamilia.Familia _object)
		{
			using (SqlConnection conn = new SqlConnection(conString))
			{

				SqlCommand sqlComm = new SqlCommand("Familia_Delete", conn);
				sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);
				sqlComm.Parameters.AddWithValue("Nombre", _object.Nombre);

				sqlComm.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter da = new SqlDataAdapter();
				da.SelectCommand = sqlComm;
				conn.Open();
				sqlComm.ExecuteNonQuery();




				//Database myDatabase = DatabaseFactory.CreateDatabase();
				//DbCommand myCommand = myDatabase.GetStoredProcCommand("Familia_Update");
				//myDatabase.AddInParameter(myCommand, "@IdFamilia", DbType.String, _object.IdFamiliaElement);
				//myDatabase.AddInParameter(myCommand, "@Nombre", DbType.String, _object.Nombre);
				//myDatabase.ExecuteNonQuery(myCommand);

				if (_object.Accesos != null)
				{
					DeleteAccesos(_object);
					Familia_Patente.DeleteAccesos(_object);
					foreach (FamiliaElement _tipo in _object.Accesos)
					{
						if (_tipo.GetType().Name == "Familia")
						{
							using (SqlConnection connection = new SqlConnection(conString))
							{

								SqlCommand sqlCommand = new SqlCommand("Familia_Familia_Insert", conn);
								sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);
								sqlComm.Parameters.AddWithValue("@IdFamiliaHijo", _object.IdFamiliaElement);
								sqlComm.CommandType = CommandType.StoredProcedure;

								SqlDataAdapter adapter = new SqlDataAdapter();
								adapter.SelectCommand = sqlCommand;
								conn.Open();
								sqlComm.ExecuteNonQuery();
							}

							//DbCommand myCommandAccesos = myDatabase.GetStoredProcCommand("Familia_Familia_Insert");
							//myDatabase.AddInParameter(myCommandAccesos, "@IdFamilia", DbType.String, _object.IdFamiliaElement);
							//myDatabase.AddInParameter(myCommandAccesos, "@IdFamiliaHijo", DbType.String, _tipo.IdFamiliaElement);
							//myDatabase.ExecuteNonQuery(myCommandAccesos);
						}
						else
						{
							using (SqlConnection connection = new SqlConnection(conString))
							{

								SqlCommand sqlCommand = new SqlCommand("Familia_Familia_Insert", conn);
								sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);
								sqlComm.Parameters.AddWithValue("@IdPatente", _object.IdFamiliaElement);
								sqlComm.CommandType = CommandType.StoredProcedure;
								SqlDataAdapter adapter = new SqlDataAdapter();
								adapter.SelectCommand = sqlCommand;
								conn.Open();
								sqlComm.ExecuteNonQuery();
							}



							//	DbCommand myCommandAccesos = myDatabase.GetStoredProcCommand("Familia_Patente_Insert");
							//	myDatabase.AddInParameter(myCommandAccesos, "@IdFamilia", DbType.String, _object.IdFamiliaElement);
							//	myDatabase.AddInParameter(myCommandAccesos, "@IdPatente", DbType.String, _tipo.IdFamiliaElement);
							//	myDatabase.ExecuteNonQuery(myCommandAccesos);
						}

					}
				}
			}
		}

		public static void Insert(ServiceLayer.Domain.PatenteFamilia.Familia _object)
		{
			using (SqlConnection conn = new SqlConnection(conString))
			{

				SqlCommand sqlComm = new SqlCommand("Familia_Insert", conn);
				sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);
				sqlComm.Parameters.AddWithValue("@Nombre", _object.Nombre);
				sqlComm.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter da = new SqlDataAdapter();
				da.SelectCommand = sqlComm;
				conn.Open();
				sqlComm.ExecuteNonQuery();
			}

			if (_object.Accesos != null)
			{
				DeleteAccesos(_object);
				Familia_Patente.DeleteAccesos(_object);
				foreach (FamiliaElement _tipo in _object.Accesos)
				{
					if (_tipo.GetType().Name == "Familia")
					{
						using (SqlConnection conn = new SqlConnection(conString))
						{

							SqlCommand sqlComm = new SqlCommand("Familia_Familia_Insert", conn);
							sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);
							sqlComm.Parameters.AddWithValue("@IdFamiliaHijo", _tipo.IdFamiliaElement);
							sqlComm.CommandType = CommandType.StoredProcedure;

							SqlDataAdapter da = new SqlDataAdapter();
							da.SelectCommand = sqlComm;
							conn.Open();
							sqlComm.ExecuteNonQuery();
						}
					}
					else
					{
						using (SqlConnection conn = new SqlConnection(conString))
						{

							SqlCommand sqlComm = new SqlCommand("Familia_Patente_Insert", conn);
							sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);
							sqlComm.Parameters.AddWithValue("@IdPatente", _tipo.IdFamiliaElement);
							sqlComm.CommandType = CommandType.StoredProcedure;

							SqlDataAdapter da = new SqlDataAdapter();
							da.SelectCommand = sqlComm;
							conn.Open();
							sqlComm.ExecuteNonQuery();
						}
					}
				}
			}
		}

		public static DataTable GetAccesos(System.String IdFamiliaElement)
		{

			DataTable data = new DataTable("test");

			using (SqlConnection conn = new SqlConnection(conString))
			{

				SqlCommand sqlComm = new SqlCommand("Familia_Familia_SelectParticular", conn);
				sqlComm.Parameters.AddWithValue("@IdFamilia", IdFamiliaElement);
				//sqlComm.Parameters.AddWithValue("@IdFamilia", IdFamiliaElement);

				sqlComm.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter da = new SqlDataAdapter();
				da.SelectCommand = sqlComm;
				conn.Open();
				sqlComm.ExecuteNonQuery();

			}
			return data;

		}

		/// <summary>
		/// Elimina las dependencias de Accesos.
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// </history>
		public static void DeleteAccesos(Domain.PatenteFamilia.Familia _object)
		{
			using (SqlConnection conn = new SqlConnection(conString))
			{

				SqlCommand sqlComm = new SqlCommand("Familia_Familia_DeleteParticular", conn);
				sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);

				sqlComm.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter da = new SqlDataAdapter();
				da.SelectCommand = sqlComm;
				conn.Open();
				sqlComm.ExecuteNonQuery();
			}
		}
	}
}