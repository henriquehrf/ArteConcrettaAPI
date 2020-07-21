using System;
using System.Collections.Generic;
using System.Text;

namespace ArteConcrettaEntity
{
	public interface IRepositorio<T> where T : class
	{
		IEnumerable<T> Todos { get; }
		void Incluir(T obj);
		void Alterar(T obj);
		void Excluir(T obj);
	}
}
