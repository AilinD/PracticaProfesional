///////////////////////////////////////////////////////////
//  Medico.cs
//  Implementation of the Class Medico
//  Generated by Enterprise Architect
//  Created on:      17-ago.-2022 22:18:42
//  Original author: ailus
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using DOMAIN;
namespace DOMAIN {
	public class Medico {

		public string Apellido { get; set; }
		public string Direccion { get; set; }
		public Guid Id { get; set; }
		public int Matricula { get; set; }
		public string Nombre { get; set; }
		//public DOMAIN.EstudiosPaciente m_EstudiosPaciente;

		public Medico(){

		}

		~Medico(){

		}

		public void AgregarMedico(){

		}

		/// 
		/// <param name="matricula"></param>
		public Medico GetMedico(int matricula){

			return null;
		}

	}//end Medico

}//end namespace DOMAIN