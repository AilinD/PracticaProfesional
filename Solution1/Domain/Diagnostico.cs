///////////////////////////////////////////////////////////
//  Diagnostico.cs
//  Implementation of the Class Diagnostico
//  Generated by Enterprise Architect
//  Created on:      17-ago.-2022 22:15:54
//  Original author: ailus
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using DOMAIN;
namespace DOMAIN {
	public class Diagnostico {

		public string diagnostico { get; set; }
		public DateTime Fecha { get; set; }
		public int Id { get; set; }
		public int MatriculaMedico { get; set; }
		public Guid Paciente { get; set; }
		//private void RequiereEstudio { get; set; }
		public DOMAIN.Medico m_Medico;

		public Diagnostico(){

		}

		~Diagnostico(){

		}

		public void AgregarDiagnostico(){

		}

	}//end Diagnostico

}//end namespace DOMAIN