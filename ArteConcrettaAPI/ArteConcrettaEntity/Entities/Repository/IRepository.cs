using System.Collections.Generic;

namespace ArteConcrettaEntity
{
	public interface IRepository<T> where T : class
	{
		IEnumerable<T> Todos { get; }
		void Incluir(T obj);
		void Alterar(T obj);
		void Excluir(T obj);
	}
}
