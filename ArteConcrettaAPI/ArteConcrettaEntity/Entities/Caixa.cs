using ArteConcrettaEntity.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArteConcrettaEntity
{
	public class Caixa
	{
		[Key]
		[Column(Order = 1)]
		public int ID { get; set; }
		[Column(Order = 2)]
		[MaxLength(50)]
		[Required]
		public string Nome { get; set; }
		[Column(Order = 3)]
		[Required]
		public decimal Saldo { get; set; }

		public ICollection<ContaPagarReceber> ContaPagarRecebe { get; set; }
	}
}
