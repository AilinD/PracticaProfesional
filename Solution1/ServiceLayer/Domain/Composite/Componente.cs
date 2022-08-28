using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Domain.Composite
{
    public abstract class Componente
    {
		public Guid IdComponent { get; set; }

		/// 
		/// <param name="component"></param>
		public abstract void Add(Componente component);

		/// 
		/// <param name="component"></param>
		public abstract void Remove(Componente component);

		/// <summary>
		/// Retorna la cantidad de hijos del elemento:
		/// Patente: 0
		/// Familia: >0
		/// </summary>
		/// <returns></returns>
		public abstract int ChildrenCount();
	}
}
