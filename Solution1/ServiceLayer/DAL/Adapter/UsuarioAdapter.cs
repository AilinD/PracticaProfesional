using ServiceLayer.DAL.PatenteFamilia;
using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceLayer.DAL.Adapter
{
    public class UsuarioAdapter
    {
        private DataRow row;

        public UsuarioAdapter(DataRow row)
        {
            this.row = row;
        }

        public void Fill(Usuario _object)
        {
            _object.IdUsuario = (System.String)row["IdUsuario"];

            _object.Nombre = (System.String)row["Nombre"];

            DataTable relacionesFamilia = Usuario_dal.GetFamilias(_object.IdUsuario);

            foreach (DataRow rowPermisos in relacionesFamilia.Rows)
            {
                FamiliaElement Permisos = Familia_Facade.GetAdapted((System.String)rowPermisos["IdFamilia"]);
                _object.Permisos.Add(Permisos);
            }

            DataTable relacionesPatente = Usuario_dal.GetPatentes(_object.IdUsuario);

            foreach (DataRow rowPermisos in relacionesPatente.Rows)
            {
                FamiliaElement Permisos = Patente_Facade.GetAdapted((System.String)rowPermisos["IdPatente"]);
                _object.Permisos.Add(Permisos);
            }
        }
    }
}
