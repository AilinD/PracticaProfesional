///////////////////////////////////////////////////////////
//  EnfermedadBLL.cs
//  Implementation of the Class EnfermedadBLL
//  Generated by Enterprise Architect
//  Created on:      18-ago.-2022 20:47:02
//  Original author: Ailin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using BLL;
using Domain;

namespace BLL.Business
{
	public class EnfermedadBLL {

        #region Singleton
        private readonly static EnfermedadBLL _instance = new EnfermedadBLL();

        public static EnfermedadBLL Current
        {
            get
            {
                return _instance;
            }
        }

        private EnfermedadBLL()
        {
            //Implement here the initialization code
        }
        #endregion

        //public BLL.PacienteBLL m_PacienteBLL;

		

		/// 
		/// <param name="enfermedad"></param>
		public void AltaEnfermedad(Enfermedad enfermedad){

		}

		/// 
		/// <param name="int"></param>
		public void BajaEnfermedad(int id){

		}

		public List<Sintoma> ListarEnfermedad(){

			return null;
		}

		/// 
		/// <param name="enfermedad"></param>
		public void ModificarEnfermedad(Enfermedad enfermedad){

		}

	}//end EnfermedadBLL

}//end namespace BLL