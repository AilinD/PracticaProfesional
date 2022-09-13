using ServiceLayer.DAL.Adapter;
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
                //GestorErrores.Execute(ex);
                throw;
            }
        }

        public static ServiceLayer.Domain.PatenteFamilia.Usuario GetAdapted(System.String IdUsuario)
        {
            try
            {
                UsuarioAdapter adapter = new UsuarioAdapter(Select(IdUsuario));
                Domain.PatenteFamilia.Usuario _object = new Domain.PatenteFamilia.Usuario();
                adapter.Fill(_object);
                return _object;
            }
            catch (Exception ex)
            {
                //GestorErrores.Execute(ex);
                throw;
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
                //GestorErrores.Execute(ex);
                throw;
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
                //GestorErrores.Execute(ex);
                throw;
            }
        }

        public static void Delete(Domain.PatenteFamilia.Usuario _object)
        {
            try
            {
                Usuario_dal.Delete(_object);
            }
            catch (Exception ex)
            {
                //GestorErrores.Execute(ex);
                throw;
            }
        }

        public static DataRow Select(System.String IdUsuario)
        {
            try
            {
                return Usuario_dal.Select(IdUsuario).Tables[0].Rows[0];
            }
            catch (Exception ex)
            {
                //GestorErrores.Execute(ex);
                throw;
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
                //GestorErrores.Execute(ex);
                throw;
            }
        }

        public static Domain.PatenteFamilia.Usuario GetUsuario(string user)
        {
            try
            {
                return Usuario_dal.GetUsuarioByNameAndPassword(user);

            }
            catch (Exception ex)
            {
                //GestorErrores.Execute(ex);
                throw;
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
                //GestorErrores.Execute(ex);
                throw;
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
                //GestorErrores.Execute(ex);
                throw;
            }
        }
    }
}

