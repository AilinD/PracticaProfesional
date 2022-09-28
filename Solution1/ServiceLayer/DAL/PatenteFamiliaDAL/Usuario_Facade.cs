using Serilog;
using ServiceLayer.DAL.Adapter;
using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Data;

namespace ServiceLayer.DAL.PatenteFamilia
{
    public class Usuario_Facade
    {
        public static List<Domain.PatenteFamilia.Usuario> GetAllAdapted()
        {
            try
            {
                UsuarioCollectionAdapter adapter = new UsuarioCollectionAdapter(SelectAll());
                List<Domain.PatenteFamilia.Usuario> collection = new List<Domain.PatenteFamilia.Usuario>();
                adapter.Fill(collection);
                return collection;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                throw ex;
            }
        }

        public static ServiceLayer.Domain.PatenteFamilia.Usuario GetAdapted(string usuario)
        {
            try
            {
                UsuarioAdapter adapter = new UsuarioAdapter(Select(usuario));
                Domain.PatenteFamilia.Usuario _object = new Domain.PatenteFamilia.Usuario();
                adapter.Fill(_object);
                return _object;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                throw ex;
            }
        }

        public static void Insert(Domain.PatenteFamilia.Usuario _object)
        {
            try
            {
                ServiceLayer.DAL.PatenteFamilia.Usuario_dal.Insert(_object);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                throw ex;
            }
        }
        /// <summary>
        /// Este metodo lo utilizo....
        /// </summary>
        /// <param name="_object">Este p</param>
        public static void Update(Domain.PatenteFamilia.Usuario _object)
        {
            try
            {
                Usuario_dal.Update(_object);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                throw ex;
            }
        }

        public static void Delete(ServiceLayer.Domain.PatenteFamilia.Usuario _object)
        {
            try
            {
                Usuario_dal.Delete(_object);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                throw ex;
            }
        }

        public static DataRow Select(string usuario)
        {
            try
            {
                return Usuario_dal.Select(usuario).Tables[0].Rows[0];
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                throw ex;
            }
        }

        public static DataTable SelectAll()
        {
            try
            {
                return Usuario_dal.SelectAll().Tables[0];
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                throw ex;
            }
        }

        public static Domain.PatenteFamilia.Usuario GetUsuario(string user, string contraseña)
        {
            try
            {
                return Usuario_dal.GetUsuarioByNameAndPassword(user,contraseña);

            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                throw ex;
            }

        }

        public static void DeleteFamilias(Domain.PatenteFamilia.Usuario _object)
        {
            try
            {
                Usuario_dal.DeleteFamilias(_object);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                throw ex;
            }
        }

        public static void DeletePatentes(Domain.PatenteFamilia.Usuario _object)
        {
            try
            {
                Usuario_dal.DeletePatentes(_object);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                throw ex;
            }
        }
    }
}

