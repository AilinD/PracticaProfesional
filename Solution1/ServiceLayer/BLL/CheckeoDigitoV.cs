using ServiceLayer.DAL.Implementaciones;
using ServiceLayer.DAL.Interfaces;
using ServiceLayer.Domain.PatenteFamilia;

using ServiceLayer.Servicios.Hash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BLL
{
    public class CheckeoDigitoV
    {
        #region Singleton
        private readonly static CheckeoDigitoV _instance = new CheckeoDigitoV();

        public static CheckeoDigitoV Current
        {
            get
            {
                return _instance;
            }
        }

        private CheckeoDigitoV()
        {
            //Implement here the initialization code
        }
        #endregion
        public static string GenerarDVH(Usuario entity)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";

            Type t = entity.GetType();
            string dvh = string.Empty;
            var props = t.GetProperties();


            var attrs = t.GetCustomAttributes(false);

            var verificable = (VerificableAttribute)attrs.Where(i => i.GetType().Equals(typeof(VerificableAttribute))).FirstOrDefault();

            if (verificable != null)
                dvh += $"{verificable.Prefix}_";


            foreach (var item in props)
            {


                if (item.PropertyType.FullName.Equals(typeof(DateTime).FullName))
                {
                    DateTime a = (DateTime)item.GetValue(entity);
                    dvh += a.ToString("ddmmyyyyhhmmss");
                }
                else
                {
                    dvh += item.GetValue(entity).ToString();

                }
            }

            return Hashing.EncryptString(dvh,key);
        }

    }
}
