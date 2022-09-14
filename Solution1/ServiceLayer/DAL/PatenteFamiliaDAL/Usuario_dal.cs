using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DAL.PatenteFamilia
{
    public class Usuario_dal
    {
        readonly static string conString;

        static Usuario_dal()
        {
            conString = @"Data Source=DESKTOP-H0P0HUN\SQLEXPRESS;Initial Catalog=PatenteFamilia;Integrated Security=True";
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

                throw ex;
            }
        }

        public static Domain.PatenteFamilia.Usuario GetUsuarioByNameAndPassword(string user)
        {
            try
            {



                DataTable data = new DataTable();
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    Domain.PatenteFamilia.Usuario usuario = new Domain.PatenteFamilia.Usuario();


                    SqlCommand sqlComm = new SqlCommand("Usuario_ByUserName", conn);
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
                        usuario.Password = dr["password"].ToString();
                        usuario.IdUsuario = dr["IdUsuario"].ToString();


                    }
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
        public static DataSet Select(System.String IdUsuario)
        {
            try
            {

                DataSet ds = new DataSet("test");
                using (SqlConnection conn = new SqlConnection(conString))
                {

                    SqlCommand sqlComm = new SqlCommand("Usuario_Select", conn);
                    sqlComm.Parameters.AddWithValue("@IdUsuario", IdUsuario);


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
        public static void Delete(Domain.PatenteFamilia.Usuario _object)
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



                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;
                conn.Open();
                sqlComm.ExecuteNonQuery();


            }
        }

        public static void Update(Domain.PatenteFamilia.Usuario _object)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {

                SqlCommand sqlComm = new SqlCommand("Usuario_Update", conn);
                sqlComm.Parameters.AddWithValue("@IdUsuario", _object.IdUsuario);
                sqlComm.Parameters.AddWithValue("@Nombre", _object.Nombre);


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
        }


        public static void Insert(Domain.PatenteFamilia.Usuario _object)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {

                SqlCommand sqlComm = new SqlCommand("Usuario_Insert", conn);
                sqlComm.Parameters.AddWithValue("@IdUsuario", _object.IdUsuario);
                sqlComm.Parameters.AddWithValue("@Nombre", _object.Nombre);
                sqlComm.Parameters.AddWithValue("password", _object.Password);



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
        }


        public static DataTable GetFamilias(System.String IdUsuario)
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
        }


        public static void DeletePatentes(Domain.PatenteFamilia.Usuario _object)
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
        }
    }
}