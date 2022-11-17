
using System;
using System.Collections.Generic;

namespace Services.Domain
{
	public class Usuario
	{
		private System.String _idUsuario;
		private System.String _nombre;
		private System.String _password;
		private List<FamiliaElement> _permisos = new List<FamiliaElement>();

		public Usuario()
		{
			
		}

		public System.String IdUsuario
		{
			get
			{
                
                return _idUsuario;
			}
			set
			{
				_idUsuario = value;
			}
		}

		public System.String Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				_nombre = value;
			}
		}

		public System.String Password
		{
			get
			{

				return _password;
			}
			set
			{
				_password = value;
			}
		}

		public List<FamiliaElement> Permisos
		{
			get
			{
				return _permisos;
			}
			set
			{
				_permisos = value;
			}
		}
	}
}

