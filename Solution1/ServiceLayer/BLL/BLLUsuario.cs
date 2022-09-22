using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BLL
{
    public static class BLLUsuario
    {
        public static ServiceLayer.Domain.PatenteFamilia.Sesion GetUsuarioByUserName(string user)
        {
            try
            {
                var call = DAL.PatenteFamilia.Usuario_Facade.GetUsuario(user);
                return new Sesion() {usuario=call };

            }
            catch (Exception ex)
            {
                //throw ex;
                throw ex;
            }
            
        }

		public static List<Domain.PatenteFamilia.Usuario> GetAllAdapted()
		{
			try
			{
				return DAL.PatenteFamilia.Usuario_Facade.GetAllAdapted();
			}
			catch (Exception ex)
			{

				throw  ex;
			}
		}
		public static Domain.PatenteFamilia.Usuario GetAdapted(System.String IdUsuario)
		{
			try
			{
				return DAL.PatenteFamilia.Usuario_Facade.GetAdapted(IdUsuario);
			}
			catch (Exception ex)
			{

				throw  ex;
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
		public static DataRow Select(System.String IdUsuario)
		{
			try
			{
				return DAL.PatenteFamilia.Usuario_Facade.Select(IdUsuario);
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
