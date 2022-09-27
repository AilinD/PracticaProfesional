using ServiceLayer.DAL.PatenteFamilia;
using ServiceLayer.Domain.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Servicios.Login
{
    internal class ServiceLogin
    {
        public bool ValidationLogin(string usuario, string pass)
        {
            try
            {
                if (usuario == null && pass == null)
                {
                    return false;
                }
                else if (usuario != null && pass != null)
                {
                    var verificacionUsuario = Usuario_dal.Select(usuario);
                   // var verificacionPass = 
                    return true;
                }
            }
            catch (Exception ex)
            {
                
            }
            return false;

        }
    }
}
