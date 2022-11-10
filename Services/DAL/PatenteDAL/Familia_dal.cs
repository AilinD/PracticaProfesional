

using Services.Domain;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using Services.BLL.Exepciones;
using Services.BLL;
using System.Diagnostics.Tracing;

namespace Services.DAL.PatenteDAL
{
    public static class Familia_dal
	{
        private static string ctr = string.Empty;

        static Familia_dal()
        {
            ctr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        }

		/// <summary>
		/// Selecciona todos los registros de una tabla
		/// </summary>
		/// <returns></returns>
        public  static DataSet SelectAll()
		{
			try
			{
				DataSet ds = new DataSet("test");
                using (SqlConnection conn = new SqlConnection(ctr))
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
			}

			catch (DALException ex)
			{
                LoggerBLL.WriteLog("Select All Familia_dal Fallo", EventLevel.Error, "");
            }
			return null;
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
                using (SqlConnection conn = new SqlConnection(ctr))
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


				//Log.Information("",Environment.GetEnvironmentVariable(""));
			}
			catch (DALException ex)
			{
                LoggerBLL.WriteLog("Select Familia_dal Fallo", EventLevel.Error, "");
            }
			return null;
		}

		/// <summary>
		/// Suprime un registro de la tabla Familia por una clave primaria(primary key).
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// </history>
		public static  void Delete(Familia _object)
		{
			if (_object.Accesos != null)
				DeleteAccesos(_object);
			try
			{


                using (SqlConnection conn = new SqlConnection(ctr))
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
			}catch(DALException ex)
			{
                LoggerBLL.WriteLog("Delete Familia_dal Fallo", EventLevel.Error, "");

            }
        }

        /// <summary>
        /// Actualiza registros de la tabla Familia.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// </history>
        public static void Update(Familia _object)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ctr))
                {

                    SqlCommand sqlComm = new SqlCommand("Familia_Delete", conn);
                    sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);
                    sqlComm.Parameters.AddWithValue("Nombre", _object.Nombre);

                    sqlComm.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    conn.Open();
                    sqlComm.ExecuteNonQuery();


                    if (_object.Accesos != null)
                    {
                        DeleteAccesos(_object);
                        Familia_Patente.DeleteAccesos(_object);
                        foreach (FamiliaElement _tipo in _object.Accesos)
                        {
                            if (_tipo.GetType().Name == "Familia")
                            {
                                using (SqlConnection connect = new SqlConnection(ctr))
                                {

                                    SqlCommand sqlCommand = new SqlCommand("Familia_Familia_Insert", connect);
                                    sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);
                                    sqlComm.Parameters.AddWithValue("@IdFamiliaHijo", _object.IdFamiliaElement);
                                    sqlComm.CommandType = CommandType.StoredProcedure;

                                    SqlDataAdapter adapter = new SqlDataAdapter();
                                    adapter.SelectCommand = sqlCommand;
                                    connect.Open();
                                    sqlComm.ExecuteNonQuery();
                                }

                                //DbCommand myCommandAccesos = myDatabase.GetStoredProcCommand("Familia_Familia_Insert");
                                //myDatabase.AddInParameter(myCommandAccesos, "@IdFamilia", DbType.String, _object.IdFamiliaElement);
                                //myDatabase.AddInParameter(myCommandAccesos, "@IdFamiliaHijo", DbType.String, _tipo.IdFamiliaElement);
                                //myDatabase.ExecuteNonQuery(myCommandAccesos);
                            }
                            else
                            {
                                using (SqlConnection connect = new SqlConnection(ctr))
                                {

                                    SqlCommand sqlCommand = new SqlCommand("Familia_Familia_Insert", connect);
                                    sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);
                                    sqlComm.Parameters.AddWithValue("@IdPatente", _object.IdFamiliaElement);
                                    sqlComm.CommandType = CommandType.StoredProcedure;
                                    SqlDataAdapter adapter = new SqlDataAdapter();
                                    adapter.SelectCommand = sqlCommand;
                                    connect.Open();
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
            catch (DALException ex)
            {
                LoggerBLL.WriteLog("Update Familia_dal Fallo", EventLevel.Error, "");

                throw;
            }
        }

        /// <summary>
        /// Llama al sp Familia_Insert e inserta un registro un registro una tabla
        /// </summary>
        /// <param name="_object"></param>
        public static  void Insert( Familia _object)
		{
			try
			{
                using (SqlConnection connect = new SqlConnection(ctr))
                {

                    SqlCommand sqlComm = new SqlCommand("Familia_Insert", connect);
                    sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);
                    sqlComm.Parameters.AddWithValue("@Nombre", _object.Nombre);
                    sqlComm.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    connect.Open();
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
                using (SqlConnection conn = new SqlConnection(ctr))
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
                using (SqlConnection conn = new SqlConnection(ctr))
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
            catch(DALException ex)
			{
                LoggerBLL.WriteLog("Insert familia_dal Fallo", EventLevel.Error, "");

            }


        }

        /// <summary>
        /// Obtiene los accesos del id de una familia
        /// </summary>
        /// <param name="IdFamiliaElement"></param>
        /// <returns></returns>
        public  static DataTable GetAccesos(System.String IdFamiliaElement)
		{
			try
			{
                DataTable data = new DataTable("test");

                using (SqlConnection connect = new SqlConnection(ctr))
                {

                    SqlCommand sqlComm = new SqlCommand("Familia_Familia_SelectParticular", connect);
                    sqlComm.Parameters.AddWithValue("@IdFamilia", IdFamiliaElement);
                    //sqlComm.Parameters.AddWithValue("@IdFamilia", IdFamiliaElement);

                    sqlComm.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    connect.Open();
                    sqlComm.ExecuteNonQuery();

                   // ex.Handle(this);
                }
                return data;
            }
			catch (DALException ex)
			{
                LoggerBLL.WriteLog("Get Accesos Familia_dal Fallo", EventLevel.Error, "");

            }
            return null;


        }

        /// <summary>
        /// Elimina las dependencias de Accesos.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// </history>
        public static  void DeleteAccesos( Familia _object)
		{
			try
			{
                using (SqlConnection connect = new SqlConnection(ctr))
                {

                    SqlCommand sqlComm = new SqlCommand("Familia_Familia_DeleteParticular", connect);
                    sqlComm.Parameters.AddWithValue("@IdFamilia", _object.IdFamiliaElement);

                    sqlComm.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    connect.Open();
                    sqlComm.ExecuteNonQuery();
                }
            }
			catch (DALException ex)
			{
                //BLL.Exepciones.ExceptionManager.Current.Handle(ex);
                LoggerBLL.WriteLog("DeleteAccesos familia_dal Fallo", EventLevel.Error, "");
 
            }

        }
    }
}