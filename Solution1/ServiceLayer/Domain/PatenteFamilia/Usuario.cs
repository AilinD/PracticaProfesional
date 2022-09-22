

using ServiceLayer.Domain.PatenteFamilia;
using ServiceLayer.Servicios.Hash;
using System;
using System.Collections.Generic;

namespace ServiceLayer.Domain.PatenteFamilia
{
	public class Usuario
	{
		private System.String _idUsuario;
		private System.String _nombre;
		private System.String _password;
		private List<FamiliaElement> _permisos = new List<FamiliaElement>();

		public Usuario()
		{
			_idUsuario = Guid.NewGuid().ToString();
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
				var key = "b14ca5898a4e4133bbce2ea2315a1916";
				var encryptedpass = Hashing.EncryptString(_password,key);
				return encryptedpass;
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

