using ArteConcrettaCore.Models;
using System.Collections.Generic;

namespace ArteConcrettaEntity.Entities.Repositorio.Interfaces
{
	public interface ICaixaRepository
	{
		IEnumerable<CaixaVm> RetornarTodosCaixa();
	}
}
