using DAL.Patente;
using Domain;
using System.Data;

namespace ServiceLayer.BLL
{
	public class BLLFamilia
	{
        #region Singleton
        private readonly static BLLFamilia _instance = new BLLFamilia();

        public static BLLFamilia Current
        {
            get
            {
                return _instance;
            }
        }

        #endregion

        public static List<Familia> GetAllAdapted()
		{
			try
			{
				return Familia_Facade.GetAllAdapted();
			}
			catch (Exception ex)
			{
				throw ex;

			}
		}
		public static Familia GetAdapted(System.String IdFamiliaElement)
		{
			try
			{
				return Familia_Facade.GetAdapted(IdFamiliaElement);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static void Insert( Familia _object)
		{
			try
			{
				Familia_Facade.Insert(_object);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public static void Update(Familia _object)
		{
			try
			{
				Familia_Facade.Update(_object);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static void Delete(Familia _object)
		{
			try
			{
				Familia_Facade.Delete(_object);
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
				return Familia_Facade.Select(IdFamiliaElement);
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
				return Familia_Facade.SelectAll();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public static void DeleteAccesos(Familia _object)
		{
			try
			{
				Familia_Facade.DeleteAccesos(_object);
			}
			catch (Exception ex)
			{
				throw ex;

			}
		}
	}
}












