using AutoMapper.Configuration;

using Services.BLL;
using Services.BLL.Exepciones;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;

namespace Services.DAL.PatenteDAL
{
    public class Patente_dal
    {
        //private static IConfiguration _configuration;
        private static string ctr;
        static Patente_dal()
        {
            ctr = ConfigurationManager.ConnectionStrings["PatenteFamilia"].ConnectionString;
        }
        public static DataSet SelectAll()
        {
            try
            {
                DataSet ds = new DataSet("test");
                using (SqlConnection conn = new SqlConnection(ctr))
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
                LoggerBLL.WriteLog(ex.Message,EventLevel.Error,"");

                throw;
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
                using (SqlConnection conn = new SqlConnection(ctr))
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
                ExceptionManager.Current.Handle(ex);

                throw;
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

                using (SqlConnection conn = new SqlConnection(ctr))
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
                ExceptionManager.Current.Handle(ex);

                throw;
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
                using (SqlConnection conn = new SqlConnection(ctr))
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
                ExceptionManager.Current.Handle(ex);

                throw;
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
                using (SqlConnection conn = new SqlConnection(ctr))
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
                ExceptionManager.Current.Handle(ex);

                throw;
            }
        }
    }
}
