using Microsoft.Extensions.Configuration;
using Services.BLL;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;

namespace Services.DAL.PatenteDAL
{
    public class Patente_dal
    {
        private static IConfiguration _configuration;
       
        public static DataSet SelectAll()
        {
            try
            {
                DataSet ds = new DataSet("test");
                using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("")))
                {

                    SqlCommand sqlComm = new SqlCommand("Patente_SelectAll", conn);

                    sqlComm.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;

                    da.Fill(ds);
                    conn.Open();
                    sqlComm.ExecuteNonQuery();
                }
                return ds;

            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog("Patente_dal Fallo", EventLevel.Error, "");

                throw ex;
            }
        }

        /// <summary>
        /// Selecciona un registro desde la tabla Patente.
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
                using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("")))
                {
                    conn.Open();
                    SqlCommand sqlComm = new SqlCommand("Patente_Select", conn);
                    sqlComm.Parameters.AddWithValue("@Nombre", IdFamiliaElement);

                    sqlComm.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;

                    sqlComm.ExecuteNonQuery();

                    da.Fill(ds);
                }
                return ds;

            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog("SelectAll Patente_dal Fallo", EventLevel.Error, "");

                throw ex;
            }
        }

        /// <summary>
        /// Suprime un registro de la tabla Patente por una clave primaria(primary key).
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// </history>
        public static void Delete(Domain.Patente _object)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("")))
                {

                    SqlCommand sqlComm = new SqlCommand("Patente_Delete", conn);
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
                LoggerBLL.WriteLog("Delete Patente_dal Fallo", EventLevel.Error, "");

                throw ex;
            }
        }

        /// <summary>
        /// Actualiza registros de la tabla Patente.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// </history>
        public static void Update(Domain.Patente _object)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("")))
                {

                    SqlCommand sqlComm = new SqlCommand("Patente_Update", conn);
                    sqlComm.Parameters.AddWithValue("@Nombre", _object.Nombre);
                    sqlComm.Parameters.AddWithValue("@IdPatente", _object.IdFamiliaElement);

                    sqlComm.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    conn.Open();
                    sqlComm.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                LoggerBLL.WriteLog("Update Patente_dal Fallo", EventLevel.Error, "");

                throw ex;
            }
        }

        /// <summary>
        /// Inserta registros en la tabla Patente.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// </history>
        public static void Insert(Domain.Patente _object)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("")))
                {

                    SqlCommand sqlComm = new SqlCommand("Patente_Insert", conn);
                    sqlComm.Parameters.AddWithValue("@IdPatente", _object.IdFamiliaElement);
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
                LoggerBLL.WriteLog("insert patente_dal Fallo", EventLevel.Error, "");

                throw ex;
            }
        }
    }
}
