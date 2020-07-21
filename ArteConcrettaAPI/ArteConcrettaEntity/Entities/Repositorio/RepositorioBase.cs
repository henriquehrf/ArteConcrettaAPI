using System;
using System.Collections.Generic;

namespace ArteConcrettaEntity
{
	public class RepositorioBase<T> : IDisposable, IRepositorio<T> where T : class
	{
		protected readonly ArteConcrettaContext _contexto;

		public RepositorioBase(ArteConcrettaContext context)
		{
			_contexto = context;
		}

		public virtual IEnumerable<T> Todos => _contexto.Set<T>();

		public virtual void Alterar(T obj)
		{
			_contexto.Update<T>(obj);
			_contexto.SaveChanges();
		}

		public void Dispose()
		{
			_contexto.Dispose();
		}

		public virtual void Excluir(T obj)
		{
			_contexto.Remove<T>(obj);
			_contexto.SaveChanges();
		}

		public virtual void Incluir(T obj)
		{
			_contexto.Add<T>(obj);
			_contexto.SaveChanges();

		}
	}
}
