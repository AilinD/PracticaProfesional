using Serilog;
using ServiceLayer.Domain.PatenteFamilia;
using ServiceLayer.Servicios.Hash;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceLayer.DAL.PatenteFamilia
{
    public class Usuario_dal
    {
        readonly static string conString;

        static Usuario_dal()
        {
           // conString = @"Data Source=DESKTOP-2ECCL58\SQLEXPRESS;Initial Catalog=PatenteFamilia;Integrated Security=True";
            conString = ConfigurationManager.ConnectionStrings["MainConString4"].ConnectionString;
        }


        public static DataSet SelectAll()
        {
            try
            {

                DataSet ds = new DataSet("test");
                using (SqlConnection conn = new SqlConnection(conString))
                {

                    SqlCommand sqlComm = new SqlCommand("Usuario_SelectAll", conn);


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

        public static Domain.PatenteFamilia.Usuario GetUsuarioByNameAndPassword(string user, string contraseña)
        {
            try
            
            {

                DataTable data = new DataTable();
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    Domain.PatenteFamilia.Usuario usuario = new Domain.PatenteFamilia.Usuario();


                    SqlCommand sqlComm = new SqlCommand("GetUsuarioByNameAndPassword", conn);
                    sqlComm.Parameters.AddWithValue("@User", user);

                    sqlComm.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    conn.Open();
                    sqlComm.ExecuteNonQuery();
                    da.Fill(data);

                    foreach (DataRow dr in data.Rows)
                    {
                        var permisos = usuario.Permisos.Select(x => x.Nombre).ToString();
                        usuario.Nombre = dr["Nombre"].ToString();
                        usuario.Password = dr["Contraseña"].ToString();
                        //usuario.IdUsuario = dr["IdUsuario"].ToString();


                    }
                    string key = ConfigurationManager.AppSettings["key"];
                    string passwd = usuario.Password;
                    string basePass =Hashing.EncryptString(key, contraseña);
                    if (contraseña == basePass);
                    return usuario;



                   // return usuario;
                    
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                throw ex;
            }
        }






        /// <summary>
        /// Selecciona un registro desde la tabla Usuario.
        /// </summary>
        /// <returns>DataSet</returns>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// </history>
        public static DataSet Select(System.String Usuario)
        {
            try
            {
               
                DataSet ds = new DataSet("test");
                using (SqlConnection conn = new SqlConnection(conString))
                {

                    SqlCommand sqlComm = new SqlCommand("Usuario_ByUsername", conn);
                    sqlComm.Parameters.AddWithValue("@Nombre", Usuario);
                    //sqlComm.Parameters.AddWithValue("@Nombre",usuario.Nombre);
                    //sqlComm.Parameters.AddWithValue("@Password", usuario.Password);


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
        /// Suprime un registro de la tabla Usuario por una clave primaria(primary key).
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// </history>
        public static void Delete(Domain.PatenteFamilia.Usuario _object)
        {
            try
            {


                if (_object.Permisos != null)
                {
                    DeleteFamilias(_object);
                    DeletePatentes(_object);
                }
                using (SqlConnection conn = new SqlConnection(conString))
                {

                    SqlCommand sqlComm = new SqlCommand("Usuario_Delete", conn);
                    sqlComm.Parameters.AddWithValue("@IdUsuario", _object.IdUsuario);
                    //  sqlComm.Parameters.AddWithValue("@Password", _object.IdUsuario);


                    sqlComm.CommandType = CommandType.StoredProcedure;
                    // sqlComm.ExecuteNonQuery();

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    conn.Open();
                    sqlComm.ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
            }
        }

        public static void Update(Domain.PatenteFamilia.Usuario _object)
        {
            try
            {


                using (SqlConnection conn = new SqlConnection(conString))
                {

                    SqlCommand sqlComm = new SqlCommand("Usuario_Update", conn);
                    sqlComm.Parameters.AddWithValue("@IdUsuario", _object.IdUsuario);
                    sqlComm.Parameters.AddWithValue("@Nombre", _object.Nombre);
                    sqlComm.Parameters.AddWithValue("@Contraseña", _object.Password);


                    sqlComm.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    conn.Open();
                    sqlComm.ExecuteNonQuery();


                }

                if (_object.Permisos != null)
                {
                    DeleteFamilias(_object);
                    DeletePatentes(_object);

                    foreach (FamiliaElement _tipo in _object.Permisos)
                    {
                        if (_tipo.GetType().Name == "Familia")
                        {

                            using (SqlConnection conn = new SqlConnection(conString))
                            {

                                SqlCommand sqlComm = new SqlCommand("Usuario_Familia_Insert", conn);
                                sqlComm.Parameters.AddWithValue("@IdUsuario", _object.IdUsuario);
                                sqlComm.Parameters.AddWithValue("@IdFamilia", _tipo.IdFamiliaElement);



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

                                SqlCommand sqlComm = new SqlCommand("Usuario_Patente_Insert", conn);
                                sqlComm.Parameters.AddWithValue("@IdUsuario", _object.IdUsuario);
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
            }catch(Exception ex)
            {
                Log.Error(ex, "");
                throw ex;
            }
        }


        public static void Insert(Domain.PatenteFamilia.Usuario _object)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {

                    SqlCommand sqlComm = new SqlCommand("Usuario_Insert", conn);
                    sqlComm.Parameters.AddWithValue("@IdUsuario", _object.IdUsuario);
                    sqlComm.Parameters.AddWithValue("@Nombre", _object.Nombre);
                    //sqlComm.Parameters.AddWithValue("",DateTime.Now);
                    sqlComm.Parameters.AddWithValue("Contraseña", _object.Password);



                    sqlComm.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    conn.Open();
                    sqlComm.ExecuteNonQuery();

                }




                if (_object.Permisos != null)
                {
                    DeleteFamilias(_object);
                    DeletePatentes(_object);

                    foreach (FamiliaElement _tipo in _object.Permisos)
                    {
                        if (_tipo.GetType().Name == "Familia")
                        {
                            using (SqlConnection conn = new SqlConnection(conString))
                            {

                                SqlCommand sqlComm = new SqlCommand("Usuario_Familia_Insert", conn);
                                sqlComm.Parameters.AddWithValue("@IdUsuario", _object.IdUsuario);
                                sqlComm.Parameters.AddWithValue("@IdFamilia", _tipo.IdFamiliaElement);



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

                                SqlCommand sqlComm = new SqlCommand("Usuario_Patente_Insert", conn);
                                sqlComm.Parameters.AddWithValue("@IdUsuario", _object.IdUsuario);
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
            }catch(Exception ex)
            {
                Log.Error(ex, "");
                throw ex;
            }
        }


        public static DataTable GetFamilias(System.String IdUsuario)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {

                    DataTable data = new DataTable("Test");
                    SqlCommand sqlComm = new SqlCommand("Usuario_Familia_SelectParticular", conn);
                    sqlComm.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    sqlComm.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    da.Fill(data);
                    conn.Open();
                    sqlComm.ExecuteNonQuery();
                    return data;
                }
            }catch(Exception ex)
            {
                Log.Error(ex, "");
                throw ex;
            }
        }

        /// <summary>
        /// Elimina las dependencias de Permisos.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// </history>
        public static void DeleteFamilias(Domain.PatenteFamilia.Usuario _object)
        {
            try
            {


                using (SqlConnection conn = new SqlConnection(conString))
                {

                    SqlCommand sqlComm = new SqlCommand("Usuario_Familia_DeleteParticular", conn);
                    sqlComm.Parameters.AddWithValue("@IdUsuario", _object.IdUsuario);
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

        /// <summary>
        /// Selecciona las dependencias de Permisos.
        /// </summary>
        /// <returns>DataSet</returns>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// </history>
        public static DataTable GetPatentes(System.String IdUsuario)
        {
            try
            {


                using (SqlConnection conn = new SqlConnection(conString))
                {

                    DataTable data = new DataTable("Test");
                    SqlCommand sqlComm = new SqlCommand("Usuario_Patente_SelectParticular", conn);
                    sqlComm.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    sqlComm.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = sqlComm;
                    da.Fill(data);
                    conn.Open();
                    sqlComm.ExecuteNonQuery();
                    return data;
                }
            }catch(Exception ex)
            {
                Log.Error(ex, "");
                throw ex;
            }
        }


        public static void DeletePatentes(Domain.PatenteFamilia.Usuario _object)
        {
            try
            {


                using (SqlConnection conn = new SqlConnection(conString))
                {

                    SqlCommand sqlComm = new SqlCommand("Usuario_Patente_DeleteParticular", conn);
                    sqlComm.Parameters.AddWithValue("@IdUsuario", _object.IdUsuario);
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