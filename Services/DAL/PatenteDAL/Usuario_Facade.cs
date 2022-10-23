
using Services.Domain;
using Services.DAL;
using System.Data;
using System.Diagnostics.Tracing;
using Services.BLL;

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
                LoggerBLL.WriteLog("GetAllAdapted Usuario_Facade Fallo", EventLevel.Error, "");

                throw ex;
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
                LoggerBLL.WriteLog("GetAdapted Usuario_Facade Fallo", EventLevel.Error, "");

                throw ex;
            }
        }

        public static void Insert(Usuario _object)
        {
            try
            {
               Usuario_dal.Insert(_object);
            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog("Insert Usuario_Facade Fallo", EventLevel.Error, "");

                throw ex;
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
                LoggerBLL.WriteLog("Update Usuario_Facade Fallo", EventLevel.Error, "");

                throw ex;
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
                LoggerBLL.WriteLog("Delete Usuario_Facade Fallo", EventLevel.Error, "");

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
                LoggerBLL.WriteLog("Select Usuario_Facade Fallo", EventLevel.Error, "");

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
                LoggerBLL.WriteLog("SelectAll Usuario_Facade Fallo", EventLevel.Error, "");

                throw ex;
            }
        }

        public static Usuario GetUsuario(string user)
        {
            try
            {
                return Usuario_dal.GetUsuarioByNameAndPassword(user);

            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog("GetUsuario Usuario_Facade Fallo", EventLevel.Error, "");

                throw ex;
            }

        }

        public static void DeleteFamilias(Usuario _object)
        {
            try
            {
                Usuario_dal.DeleteFamilias(_object);
            }
            catch (Exception ex)
            {
                LoggerBLL.WriteLog("DeleteFamilias Usuario_Facade Fallo", EventLevel.Error, "");

                throw ex;
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
                LoggerBLL.WriteLog("DeletePatentes Usuario_Facade Fallo", EventLevel.Error, "");

                throw ex;
            }
        }
    }
}

