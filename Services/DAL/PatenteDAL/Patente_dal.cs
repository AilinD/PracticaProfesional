using AutoMapper.Configuration;

using Services.BLL;
using Services.BLL.Exepciones;
using Services.Domain;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;

namespace Services.DAL.PatenteDAL
{
    public class Patente_dal
    {
        //private static IConfiguration _configuration;
        private static string ctr = string.Empty;
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
                return null;

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
                return null;

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

                 
            }
        }


        public static DataTable GetPatente(Domain.Usuario _object) {

            //SpSelectPatenteUsuario

            try
                
            {
                DataTable data = new DataTable();
                using (SqlConnection conn = new SqlConnection(ctr))
                {

                    SqlCommand sqlComm = new SqlCommand("SpSelectPatenteUsuario", conn);
                    sqlComm.Parameters.AddWithValue("@IdUsuario", _object.IdUsuario);

                    sqlComm.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    conn.Open();
                    sqlComm.ExecuteNonQuery();
                    da.Fill(data);
                    //_object.Patente =;

                    foreach (DataRow dr in data.Rows)
                    {
                       
                        _object.IdPatente = dr["IdPatente"].ToString();

                        //usuario.Permisos.Add();

                    }

                }
                return data;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                return null;
            }
        }


        public static DataTable GetNombrePatente(Usuario usuario)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(ctr))
            {

                SqlCommand sqlComm = new SqlCommand("SP_GetNombre_Patente_Usuario", conn);
                sqlComm.Parameters.AddWithValue("@IdPatente", usuario.IdPatente);

                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;
                conn.Open();
                sqlComm.ExecuteNonQuery();
                da.Fill(data);


                foreach (DataRow dr in data.Rows)
                {

                    usuario.Patente = dr["Nombre"].ToString();



                }
                return data;
            }
        }
    }
}
