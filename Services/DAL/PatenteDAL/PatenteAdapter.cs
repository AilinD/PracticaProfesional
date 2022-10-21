using Services.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.PatenteDAL
{
    public  class PatenteAdapter
    {
		private DataRow row;

		public PatenteAdapter(DataRow row)
		{
			this.row = row;
		}

		public void Fill(Domain.Patente _object)
		{
			_object.IdFamiliaElement = (System.String)row["IdPatente"];

			_object.Nombre = (System.String)row["Nombre"];
		}
	}
}
