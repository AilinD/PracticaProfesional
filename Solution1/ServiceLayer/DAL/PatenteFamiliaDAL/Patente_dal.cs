using Serilog;
using ServiceLayer.Domain.PatenteFamilia;
using ServiceLayer.Servicios.Log;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DAL.PatenteFamilia
{ 
    public class Patente_dal
    {

        readonly static string conString;

        static Patente_dal()
        {
            try
            {

                //DESKTOP-RM3UB93\SQLEXPRESS

                //conString = @"Data Source=DESKTOP-2ECCL58\SQLEXPRESS;Initial Catalog=PatenteFamilia;Integrated Security=True";
                conString = ConfigurationManager.ConnectionStrings["MainConString4"].ConnectionString;

            }
            catch (Exception ex)
            {
                LoggerService.WriteLog(ex.Message,EventLevel.Error,"");
                throw ex;
            }
        }

        public static DataSet SelectAll()
        {
            try
            {
                DataSet ds = new DataSet("test");
                using (SqlConnection conn = new SqlConnection(conString))
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
                LoggerService.WriteLog(ex.Message,EventLevel.Error,"");
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
                using (SqlConnection conn = new SqlConnection(conString))
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
                LoggerService.WriteLog(ex.Message,EventLevel.Error,"");
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
        public static void Delete(Patente _object)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(conString))
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
                LoggerService.WriteLog(ex.Message,EventLevel.Error,"");
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
        public static void Update(Domain.PatenteFamilia.Patente _object)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
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
                LoggerService.WriteLog(ex.Message,EventLevel.Error,"");
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
        public static void Insert(Domain.PatenteFamilia.Patente _object)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
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
                LoggerService.WriteLog(ex.Message,EventLevel.Error,"");
                throw ex;
            }
        }
    }
}
