///////////////////////////////////////////////////////////
//  PacienteBLL.cs
//  Implementation of the Class PacienteBLL
//  Generated by Enterprise Architect
//  Created on:      18-ago.-2022 20:48:43
//  Original author: Ailin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using BLL;
using DOMAIN;

namespace BLL {
	public class PacienteBLL {

		public BLL.EstudioBLL m_EstudioBLL;
		public BLL.TurnoBLL m_TurnoBLL;
		public BLL.GuardiaBLL m_GuardiaBLL;

		public PacienteBLL(){

		}

		~PacienteBLL(){

		}

		/// 
		/// <param name="paciente"></param>
		public void AltaPaciente(Paciente paciente){

		}

		/// 
		/// <param name="int"></param>
		public void BajaPaciente(int ID){

		}

		/// 
		/// <param name="int"></param>
		public Paciente  BuscarPaciente(int ID){

			return null;
		}

		public List<Paciente> ListarPaciente(){

			return null;
		}

		/// 
		/// <param name="paciente"></param>
		public void ModificarPaciente(Paciente paciente){

		}

	}//end PacienteBLL

}//end namespace BLL