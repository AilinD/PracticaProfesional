using Services.BLL.Exepciones;
using Services.DAL.PatenteDAL;
using Services.Domain;
using System.Data;
using System.Diagnostics.Tracing;

namespace Services.BLL.PatenteBLL
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
                ExceptionManager.Current.Handle(ex);
				throw;
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
                ExceptionManager.Current.Handle(ex);
                throw;
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
                ExceptionManager.Current.Handle(ex);
                throw;
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
                ExceptionManager.Current.Handle(ex);
                throw;
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
                ExceptionManager.Current.Handle(ex);
                throw;
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
                ExceptionManager.Current.Handle(ex);
                throw;

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
                ExceptionManager.Current.Handle(ex);
                throw;
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
                ExceptionManager.Current.Handle(ex);
                throw;

			}
		}
	}
}












