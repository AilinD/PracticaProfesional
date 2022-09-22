using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BLL
{
    public class PatenteBLL
    {
		public static List<Domain.PatenteFamilia.Patente> GetAllAdapted()
		{
			try
			{
				return DAL.PatenteFamilia.Patente_Facade.GetAllAdapted();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static Domain.PatenteFamilia.Patente GetAdapted(System.String IdFamiliaElement)
		{
			try
			{
				return DAL.PatenteFamilia.Patente_Facade.GetAdapted(IdFamiliaElement);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static void Insert(Domain.PatenteFamilia.Patente _object)
		{
			try
			{
				DAL.PatenteFamilia.Patente_Facade.Insert(_object);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static void Update(Domain.PatenteFamilia.Patente _object)
		{
			try
			{
				DAL.PatenteFamilia.Patente_Facade.Update(_object);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static void Delete(Domain.PatenteFamilia.Patente _object)
		{
			try
			{
				DAL.PatenteFamilia.Patente_Facade.Delete(_object);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static DataRow Select(System.String IdFamiliaElement)
		{
			try
			{
				return DAL.PatenteFamilia.Patente_Facade.Select(IdFamiliaElement);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static DataTable SelectAll()
		{
			try
			{
				return DAL.PatenteFamilia.Patente_Facade.SelectAll();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}

 
