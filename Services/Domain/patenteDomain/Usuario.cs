
using Org.BouncyCastle.Math.EC.Rfc7748;
using System;
using System.Collections.Generic;

namespace Services.Domain
{
	public class Usuario
	{
		private System.String _idUsuario;
		private System.String _nombre;
		private System.String _password;
		private System.Int32 _IdRol;
		private System.String _patente;
		private System.String _IdPatente;
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

		public System.Int32 IdRol
		{
			get
			{
				return _IdRol;

            }
			set
			{
				_IdRol = value;

            }
		}

		public System.String Patente
		{
			get
			{
				return _patente;
			}
			set
			{
				_patente = value;
			}
		}

        public System.String IdPatente
        {
            get
            {
                return _IdPatente;
            }
            set
            {
                _IdPatente = value;
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

