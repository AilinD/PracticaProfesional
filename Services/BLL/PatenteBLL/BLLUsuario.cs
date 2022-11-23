using Services.DAL.PatenteDAL;
using Services.Domain;
using Services;
using System.Data;
using System.Diagnostics.Tracing;
using Services.Logger;
using Services.BLL.Exepciones;

namespace Services.BLL.PatenteBLL
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
                // LoggerService.WriteLog("Loguin Fallo", EventLevel.Error, "");
                //new Services.Logger.LoggerService().WriteLog("",EventLevel,"");
                //ExceptionManager.Current.Handle(ex);
                ExceptionManager.Current.Handle(ex);
                throw;
            }
            
        }

        public static Sesion GetUsuarioByUserName6Password(string user, string password)
        {
            try
            {
                var call = Usuario_Facade.GetUsuarioUserPass(user, password);

				var pat = "";

                if (call == null)
                {
					return null;
                }

                return new Sesion() { usuario = call };
                //Serilog.Log.Write("",user);
            }
            catch (Exception ex)
            {
                ExceptionManager.Current.Handle(ex);
                //new Services.Logger.LoggerService().WriteLog("",EventLevel,"");
                ExceptionManager.Current.Handle(ex);
                throw;
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
                ExceptionManager.Current.Handle(ex);
                //ExceptionManager.Current.Handle(ex);
                throw;
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
                ExceptionManager.Current.Handle(ex);

                throw;
			}
		}
		public static void Insert(Usuario _object)
		{
			try
			{
                //var key = "b14ca5898a4e4133bbce2ea2315a1916";
                //var encryptedpass = Hashing.EncryptString(key, _object.Password);

				var usertoSave = new Usuario()
				{
					IdUsuario = _object.IdUsuario,
					Nombre = _object.Nombre,
					Permisos = _object.Permisos,
					Password = _object.Password,
					IdRol=_object.IdRol
					
				};


                Usuario_Facade.Insert(usertoSave);
			}
			catch (Exception ex)
			{
                ExceptionManager.Current.Handle(ex);
                throw;
			}
		}
		public static void Update(Usuario _object)
		{
			try
			{
                var key = "b14ca5898a4e4133bbce2ea2315a1916";
                var encryptedpass = Hashing.EncryptString(key, _object.Password);
				_object.Password=encryptedpass;	
                Usuario_Facade.Update(_object);
			}
			catch (Exception ex)
			{
                ExceptionManager.Current.Handle(ex);
                throw;
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
                ExceptionManager.Current.Handle(ex);
                throw;
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
                ExceptionManager.Current.Handle(ex);
                throw;
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
                ExceptionManager.Current.Handle(ex);
                throw;
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
                ExceptionManager.Current.Handle(ex);
                throw;
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
                ExceptionManager.Current.Handle(ex);
                throw;
			}
		}
		
	}
}
