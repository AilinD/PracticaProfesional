///////////////////////////////////////////////////////////
//  EstudioBLL.cs
//  Implementation of the Class EstudioBLL
//  Generated by Enterprise Architect
//  Created on:      18-ago.-2022 20:47:42
//  Original author: Ailin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using DOMAIN;

namespace BLL {
	public class EstudioBLL {

        #region Singleton
        private readonly static EstudioBLL _instance = new EstudioBLL();

        public static EstudioBLL Current
        {
            get
            {
                return _instance;
            }
        }

        private EstudioBLL()
        {
            //Implement here the initialization code
        }
        #endregion




        /// 
        /// <param name="estudio"></param>
        public Estudio AltaEstudio(Estudio estudio){

			return null;
		}

		/// 
		/// <param name="int"></param>
		public void BajaEstudio(int ID){

		}

		public List<Estudio> ListEstudio(){

			return null;
		}

		/// 
		/// <param name="estudio"></param>
		public void ModificacionEstudio(Estudio estudio){

		}

	}//end EstudioBLL

}//end namespace BLL