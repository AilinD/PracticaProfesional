using Services.BLL.Exepciones;
using Services.DAL.PatenteDAL;
using Services.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.PatenteBLL
{
    public class PatenteBLL
    {
        #region Singleton
        private readonly static PatenteBLL _instance = new PatenteBLL();

        public static PatenteBLL Current
        {
            get
            {
                return _instance;
            }
        }

        private PatenteBLL()
        {
            //Implement here the initialization code
        }
        #endregion
        //private readonly IGenericRepository<Movie> _repo = FactoryDAL.MovieRepository;
        public static List<Patente> GetAllAdapted()
		{
			try
			{
				return Patente_Facade.GetAllAdapted();
			}
			catch (Exception ex)
			{
                ExceptionManager.Current.Handle(ex);
                 
			}
			return null;
		}
		public static Patente GetAdapted(System.String IdFamiliaElement)
		{
			try
			{
				return Patente_Facade.GetAdapted(IdFamiliaElement);
			}
			catch (Exception ex)
			{
                ExceptionManager.Current.Handle(ex);
                 
			}
			return null;
		}
		public static void Insert(Patente _object)
		{
			try
			{
				Patente_Facade.Insert(_object);
			}
			catch (Exception ex)
			{
                ExceptionManager.Current.Handle(ex);
                 
			}
		}
		public static void Update(Patente _object)
		{
			try
			{
				Patente_Facade.Update(_object);
			}
			catch (Exception ex)
			{
                ExceptionManager.Current.Handle(ex);
                 
			}
		}
		public static void Delete(Patente _object)
		{
			try
			{
				Patente_Facade.Delete(_object);
			}
			catch (Exception ex)
			{
                ExceptionManager.Current.Handle(ex);
                 
			}
		}
		public static DataRow Select(System.String IdFamiliaElement)
		{
			try
			{
				return Patente_Facade.Select(IdFamiliaElement);
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
				return Patente_Facade.SelectAll();
			}
			catch (Exception ex)
			{
                ExceptionManager.Current.Handle(ex);
                 
			}
			return null;
		}

		public static DataTable getPatenteUs(Usuario usuario)
		{
			try
			{
				return Patente_Facade.getPatenteUs(usuario);
			}
			catch (Exception ex)
			{
                ExceptionManager.Current.Handle(ex);
                 
            }

			return null;
		}

		public static DataTable GetNombrePatente(Usuario usuario)
		{
			try
			{
				return Patente_Facade.GetNombrePatente(usuario);

            }
			catch (Exception ex)
			{
                ExceptionManager.Current.Handle(ex);
                 
            }
			return null;
		}

    }
}

 
