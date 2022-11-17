using Services.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public static class SesionService
    {
        public static Sesion GetSesion(Usuario usuario)
        {
            return new Sesion { usuario = usuario };
        }
    }
}
