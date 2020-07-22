using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArteConcrettaEntity.Entities
{
	public class LancamentoMapping
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

		public CaixaMapping Caixa { get; set; }

		public TipoLancamentoMapping TipoLancamento { get; set; }

	}
}
