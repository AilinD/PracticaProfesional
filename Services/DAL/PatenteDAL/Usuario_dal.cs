using Services.Domain;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
//using ConfigurationManager = Services.ConfigurationManager;

namespace Services.DAL.PatenteDAL
{
    public static class Usuario_dal
    {
        private static string ctr;

         static Usuario_dal()
        {
            ctr = ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;
        }

        


        public static DataSet SelectAll()
        {
            try
            {

                DataSet ds = new DataSet("test");
                using (SqlConnection conn = new SqlConnection(ctr))
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
                throw ex;
            }
        }

        public static Usuario GetUsuarioByNameAndPassword(string user)
        {
            try
            
            {

                DataTable data = new DataTable();
                using (SqlConnection conn = new SqlConnection(ctr))
                {
                    Usuario usuario = new Usuario();


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
                    }

                    if (string.IsNullOrEmpty(usuario.Nombre) || (string.IsNullOrEmpty(usuario.Password)))
                    {
                        throw new Exception("Usuario Inexistente");
                    }

                    //string key = ConfigurationManager.AppSettings["key"];
                    //string passwd = usuario.Password;
                    //string basePass = Hashing.EncryptString(key, contraseña);
                    //if (contraseña == basePass);

                    return usuario;

                }
            }
            catch (Exception ex)
            {
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
                using (SqlConnection conn = new SqlConnection(ctr))
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
        public static void Delete(Usuario _object)
        {
            try
            {


                if (_object.Permisos != null)
                {
                    DeleteFamilias(_object);
                    DeletePatentes(_object);
                }
                using (SqlConnection conn = new SqlConnection(ctr))
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
            }
        }

        public static void Update(Usuario _object)
        {
            try
            {


                using (SqlConnection conn = new SqlConnection(ctr))
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

                            using (SqlConnection conn = new SqlConnection(ctr))
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
                            using (SqlConnection conn = new SqlConnection(ctr))
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
                throw ex;
            }
        }


        public static void Insert(Usuario _object)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ctr))
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
                            using (SqlConnection conn = new SqlConnection(ctr))
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
                            using (SqlConnection conn = new SqlConnection(ctr))
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
                throw ex;
            }
        }


        public static DataTable GetFamilias(System.String IdUsuario)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ctr))
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
        public static void DeleteFamilias(Usuario _object)
        {
            try
            {


                using (SqlConnection conn = new SqlConnection(ctr))
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


                using (SqlConnection conn = new SqlConnection(ctr))
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
                throw ex;
            }
        }


        public static void DeletePatentes(Usuario _object)
        {
            try
            {


                using (SqlConnection conn = new SqlConnection(ctr))
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
                throw ex;
            }
        }
    }
}