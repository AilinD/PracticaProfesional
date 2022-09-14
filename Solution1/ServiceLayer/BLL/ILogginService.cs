using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BLL
{
    public interface ILoggingService
    {
        Sesion IniciarSesion(string usuario, string pass);
    }
}
