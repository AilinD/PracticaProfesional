using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;
using System.Diagnostics.Tracing;
using ServiceLayer.Servicios.Log;

namespace ServiceLayer.BLL
{
    public static class BLLUsuario
    {
        public static ServiceLayer.Domain.PatenteFamilia.Sesion GetUsuarioByUserName(string user, string contraseña)
        {
            try
            {
                var call = DAL.PatenteFamilia.Usuario_Facade.GetUsuario(user,contraseña);

                if (call == null)
                {
                    
                }

                return new Sesion() {usuario=call };
				//Serilog.Log.Write("",user);
            }
            catch (Exception ex)
            {
                  LoggerBLL.WriteLog("Loguin Fallo", EventLevel.Error, "");
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


        public static List<Domain.PatenteFamilia.Usuario> GetAllAdapted()
		{
			try
			{
				return DAL.PatenteFamilia.Usuario_Facade.GetAllAdapted();
				  
			}
			catch (Exception ex)
			{
                  LoggerBLL.WriteLog("Loguin Fallo", EventLevel.Error, "");
               throw ex;
			}
		}
		public static Domain.PatenteFamilia.Usuario GetAdapted(string usuario)
		{
			try
			{
				return DAL.PatenteFamilia.Usuario_Facade.GetAdapted(usuario);
			}
			catch (Exception ex)
			{
                  LoggerBLL.WriteLog("Loguin Fallo", EventLevel.Error, "");

                throw ex;
			}
		}
		public static void Insert(Domain.PatenteFamilia.Usuario _object)
		{
			try
			{
				DAL.PatenteFamilia.Usuario_Facade.Insert(_object);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static void Update(Domain.PatenteFamilia.Usuario _object)
		{
			try
			{
				DAL.PatenteFamilia.Usuario_Facade.Update(_object);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static void Delete(Domain.PatenteFamilia.Usuario _object)
		{
			try
			{
				DAL.PatenteFamilia.Usuario_Facade.Delete(_object);
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
				return DAL.PatenteFamilia.Usuario_Facade.Select(usuario);
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
               
				return DAL.PatenteFamilia.Usuario_Facade.SelectAll();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static void DeleteFamilias(Domain.PatenteFamilia.Usuario _object)
		{
			try
			{
				DAL.PatenteFamilia.Usuario_Facade.DeleteFamilias(_object);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static void DeletePatentes(Domain.PatenteFamilia.Usuario _object)
		{
			try
			{
				DAL.PatenteFamilia.Usuario_Facade.DeletePatentes(_object);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		
	}
}
