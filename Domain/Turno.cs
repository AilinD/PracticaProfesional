///////////////////////////////////////////////////////////
//  Turno.cs
//  Implementation of the Class Turno
//  Generated by Enterprise Architect
//  Created on:      17-ago.-2022 22:21:44
//  Original author: ailus
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Domain
{
	public class Turno {

		public int DNIPaciente { get; set; }
		public DateTime Fecha { get; set; }
		public Guid Id { get; set; }
		public int IdRecepcionista { get; set; }
		public Guid MarticulaM { get; set; }

		public Turno(){

		}


		public void SolicitarTurno(){

		}

	}//end Turno

}//end namespace DOMAIN