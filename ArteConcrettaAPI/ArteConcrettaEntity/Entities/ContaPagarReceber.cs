using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace ArteConcrettaEntity.Entities
{
	public class ContaPagarReceber
	{
		[Key]
		[Column(Order = 1)]
		public int IDContaPagarReceber { get; set; }

		[Required]
		[Column(Order = 2)]
		[ForeignKey("Cliente")]
		public int IDCliente { get; set; }

		[Required]
		[Column(Order = 3)]
		public char TipoOperacao { get; set; }

		[Required]
		[MaxLength(100)]
		[Column(Order = 4)]
		public string Descricao { get; set; }

		[Required]
		[Column(Order = 5)]
		public DateTime DataVencimento { get; set; }

		[Column(Order = 6)]
		public DateTime? DataPagamento { get; set; }

		[Required]
		[Column(Order = 7)]
		public decimal Valor { get; set; }

		[Column(Order = 8)]
		public decimal ValorPago { get; set; }

		[Column(Order = 9)]
		[ForeignKey("Caixa")]
		public int? IDCaixa { get; set; }
		
		public Cliente Cliente { get; set; }
		public Caixa Caixa { get; set; }

	}
}
