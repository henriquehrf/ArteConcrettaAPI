using ArteConcrettaCore.Models;
using ArteConcrettaCore.Utils;
using ArteConcrettaEntity.Entities.Repositorio.Interfaces;
using System;
using System.Collections.Generic;

namespace ArteConcrettaEntity.Entities.Repository
{
	public class CaixaRepository : RepositoryBase<CaixaMapping>, ICaixaRepository
	{
		public CaixaRepository(ArteConcrettaContext context) : base(context)
		{
		}

		public IEnumerable<CaixaVm> RetornarTodosCaixa()
		{
			return Todos.ConverterList<CaixaVm>();
		}
	}
}
