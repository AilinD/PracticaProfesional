using DAL.Patente;
using Domain;
using Services;
using System.Data;
using System.Diagnostics.Tracing;

namespace ServiceLayer.BLL
{
	public static class BLLUsuario
    {
        public static Sesion GetUsuarioByUserName(string user)
        {
            try
            {
                var call = Usuario_Facade.GetUsuario(user);

                if (call == null)
                {
                    
                }

                return new Sesion() {usuario=call };
				//Serilog.Log.Write("",user);
            }
            catch (Exception ex)
            {
                  //LoggerBLL.WriteLog("Loguin Fallo", EventLevel.Error, "");
                throw ex;
            }
            
        }
       
		public static bool TryLogin(string usuario, string contraseña )
		{
			if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
				return false;
			else if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(contraseña))
				return false;
			return true;
		}


        public static List<Usuario> GetAllAdapted()
		{
			try
			{
				return Usuario_Facade.GetAllAdapted();
				  
			}
			catch (Exception ex)
			{
                  //LoggerBLL.WriteLog("Loguin Fallo", EventLevel.Error, "");
               throw ex;
			}
		}
		public static Usuario GetAdapted(string usuario)
		{
			try
			{
				return Usuario_Facade.GetAdapted(usuario);
			}
			catch (Exception ex)
			{
                  //LoggerBLL.WriteLog("Loguin Fallo", EventLevel.Error, "");

                throw ex;
			}
		}
		public static void Insert(Usuario _object)
		{
			try
			{
                var key = "b14ca5898a4e4133bbce2ea2315a1916";
                var encryptedpass = Hashing.EncryptString(key, _object.Password);

				var usertoSave = new Usuario()
				{
					IdUsuario = _object.IdUsuario,
					Nombre = _object.Nombre,
					Permisos = _object.Permisos,
					Password = encryptedpass
				};


                Usuario_Facade.Insert(usertoSave);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static void Update(Usuario _object)
		{
			try
			{
			Usuario_Facade.Update(_object);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static void Delete(Usuario _object)
		{
			try
			{
				Usuario_Facade.Delete(_object);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static void Getpermisos(List<string> permisos)
		{
		}
		public static DataRow Select(string usuario)
		{
			try
			{
				return Usuario_Facade.Select(usuario);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		
		public static System.Data.DataTable SelectAll()
		{
			try
			{
               
				return Usuario_Facade.SelectAll();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static void DeleteFamilias(Usuario _object)
		{
			try
			{
				Usuario_Facade.DeleteFamilias(_object);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static void DeletePatentes(Usuario _object)
		{
			try
			{
		Usuario_Facade.DeletePatentes(_object);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		
	}
}
