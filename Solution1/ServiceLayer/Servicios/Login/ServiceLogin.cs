using ServiceLayer.DAL.PatenteFamilia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Servicios.Login
{
    internal class ServiceLogin
    {
        public bool ValidationLogin(string user, string pass)
        {
            try
            {
                if (user == null && pass == null)
                {
                    return false;
                }
                else if (user != null && pass != null)
                {
                    var verificacionUsuario = Usuario_dal.Select(user);
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
