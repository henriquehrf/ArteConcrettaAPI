using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArteConcrettaEntity.Entities
{
	public class TipoLancamentoMapping
	{
		[Key]
		[Column(Order = 1)]
		public int IDTipoLancamento { get; set; }

		[Column(Order = 2)]
		[MaxLength(50)]
		public string Nome { get; set; }

		[Column(Order = 3)]
		public char EntradaSaida { get; set; }


		public ICollection<LancamentoMapping> Lancamentos { get; set; }
	}
}
