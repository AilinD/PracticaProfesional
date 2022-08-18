///////////////////////////////////////////////////////////
//  Paciente.cs
//  Implementation of the Class Paciente
//  Generated by Enterprise Architect
//  Created on:      17-ago.-2022 22:19:57
//  Original author: ailus
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



//using Domain Model;
//using DOMAIN;
//using DAL;

namespace DOMAIN {
	public class Paciente {

		public string Apellido { get; set; }
		public int Celular { get; set; }
		public string Direcci�n { get; set; }
		public int DNI { get; set; }
		public DateTime FechaNacimiento { get; set; }
		public Guid IdPaciente { get; set; }
		public string Nombre { get; set; }
		//public Domain Model.Medicos m_Medicos;
		public DOMAIN.Historial_Paciente m_Historial_Paciente;
		public DOMAIN.Turno m_Turno;
		public DOMAIN.Diagnostico m_Diagnostico;

		public Paciente(){

		}

		~Paciente(){

		}

	}//end Paciente

}//end namespace DOMAIN