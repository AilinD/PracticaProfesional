using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Domain.PatenteFamilia
{
 
        public class Patente : FamiliaElement
        {
            public Patente()
            {

            }

            public override void Add(FamiliaElement d)
            {
                throw new Exception("No se puede agregar una patente");
            }

            public override void Remove(FamiliaElement d)
            {
                throw new Exception("No se puede quitar una patente");
            }

            public override void GetPermissions(List<string> permisos)
            {
                permisos.Add(Nombre);
            }

            public override int ChildrenCount
            {
                get
                {
                    return 0;
                }
            }
        }
    
}
