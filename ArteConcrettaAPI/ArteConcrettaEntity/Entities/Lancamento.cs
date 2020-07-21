using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArteConcrettaEntity.Entities
{
	public class Lancamento
	{
		[Key]
		[Column(Order = 1)]
		public int IDLancamento { get; set; }

		[Required]
		[ForeignKey("Caixa")]
		public int IDCaixa { get; set; }

		[Required]
		public decimal Valor { get; set; }

		[Required]
		[MaxLength(100)]
		public string Descricao { get; set; }

		[Required]
		[ForeignKey("TipoLancamento")]
		public int IDTipoLancamento { get; set; }

		[Required]
		public DateTime DataLancamento { get; set; }

		public Caixa Caixa { get; set; }

		public TipoLancamento TipoLancamento { get; set; }

	}
}
