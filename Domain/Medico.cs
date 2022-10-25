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
using System.ComponentModel.DataAnnotations;

namespace Domain
{
	public class Medico {
		[Key]
		public int Id { get; set; }
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
		public string Direccion { get; set; }
		public int Contacto { get; set; }


		public ICollection<Especialidad> Especialidades { get; set; }

		

	}//end Medico

}//end namespace DOMAIN