///////////////////////////////////////////////////////////
//  EstudiosPaciente.cs
//  Implementation of the Class EstudiosPaciente
//  Generated by Enterprise Architect
//  Created on:      17-ago.-2022 22:16:50
//  Original author: ailus
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using DOMAIN;
namespace DOMAIN {
	public class EstudiosPaciente {

		public string Comentarios { get; set; }
		public Guid DNI { get; set; }
		public Guid Estudio { get; set; }
		public DateTime Fecha { get; set; }
		public Guid MatriculaMedico { get; set; }
		//public DOMAIN.Paciente m_Paciente;

		public EstudiosPaciente(){

		}

		public void SolicitarTurnoPaciente(){

		}

	}//end EstudiosPaciente

}//end namespace DOMAIN