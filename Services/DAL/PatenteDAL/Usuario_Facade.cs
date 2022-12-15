
using Services.Domain;
using Services.DAL;
using System.Data;
using System.Diagnostics.Tracing;
using Services.BLL;
using Services.BLL.Exepciones;

namespace Services.DAL.PatenteDAL
{
    public static class Usuario_Facade
    {

        public static List<Usuario> GetAllAdapted()
        {
            try
            {
                UsuarioCollectionAdapter adapter = new UsuarioCollectionAdapter(SelectAll());
                List<Usuario> collection = new List<Usuario>();
                adapter.Fill(collection);
                return collection;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                return null;
            }
        }

        public static Usuario GetAdapted(string usuario)
        {
            try
            {
                UsuarioAdapter adapter = new UsuarioAdapter(Select(usuario));
                Usuario _object = new Usuario();
                adapter.Fill(_object);
                return _object;
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                
            }
            return null;
        }

        public static void Insert(Usuario _object)
        {
            try
            {
               Usuario_dal.Insert(_object);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
        }
        /// <summary>
        /// Este metodo lo utilizo....
        /// </summary>
        /// <param name="_object">Este p</param>
        public static void Update(Usuario _object)
        {
            try
            {
                Usuario_dal.Update(_object);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
        }

        public static void Delete(Usuario _object)
        {
            try
            {
                Usuario_dal.Delete(_object);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
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
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;
        }

        public static DataTable SelectAll()
        {
            try
            {
                return Usuario_dal.SelectAll().Tables[0];
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;
        }

        public static Usuario GetUsuario(string user)
        {
            try
            {
                return Usuario_dal.GetUsuarioByName(user);

            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;
        }


        public static Usuario GetUsuarioUserPass(string user, string password)
        {
            try
            {
                return Usuario_dal.GetUsuarioByNameAndPassword(user, password);

            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
            return null;

        }

        public static void DeleteFamilias(Usuario _object)
        {
            try
            {
                Usuario_dal.DeleteFamilias(_object);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
        }

        public static void DeletePatentes(Usuario _object)
        {
            try
            {
                Usuario_dal.DeletePatentes(_object);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);

                 
            }
        }
    }
}

