﻿using Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.PatenteFamilia
{

    public class Patente_dal
    {

        readonly static string conString;

        static Patente_dal()
        {
            try
            {



                conString = @"Data Source=DESKTOP-RM3UB93\SQLEXPRESS;Initial Catalog=PatenteFamilia;Integrated Security=True";

            }
            catch (Exception ex)
            {
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
        /// 	[lenovo]	04/06/2013 01:53:03 a.m.
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
                    sqlComm.Parameters.AddWithValue("@IdPatente", IdFamiliaElement);

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

                throw ex;
            }
        }

        /// <summary>
        /// Suprime un registro de la tabla Patente por una clave primaria(primary key).
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// 	[lenovo]	04/06/2013 01:53:03 a.m.
        /// </history>
        public static void Delete(Patente _object)
        {


            using (SqlConnection conn = new SqlConnection(conString))
            {

                SqlCommand sqlComm = new SqlCommand("Patente_Delete", conn);
                sqlComm.Parameters.AddWithValue("@IdFamiliaElement", _object.IdFamiliaElement);

                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;
                conn.Open();
                sqlComm.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Actualiza registros de la tabla Patente.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// 	[lenovo]	04/06/2013 01:53:03 a.m.
        /// </history>
        public static void Update(Domain.PatenteFamilia.Patente _object)
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
        }

        /// <summary>
        /// Inserta registros en la tabla Patente.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// 	[lenovo]	04/06/2013 01:53:03 a.m.
        /// </history>
        public static void Insert(Domain.PatenteFamilia.Patente _object)
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
    }
}