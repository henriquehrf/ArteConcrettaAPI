using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArteConcrettaEntity.Entities
{
	public class Cliente
	{
		[Key]
		[Column(Order = 1)]
		public int IDCliente { get; set; }

		[Required]
		[MaxLength(50)]
		[Column(Order = 2)]
		public string Nome { get; set; }

		[Column(Order = 3)]
		public string Contato { get; set; }

		[Column(Order = 4)]
		public string Endereco { get; set; }

		public ICollection<ContaPagarReceber> ContaPagarRecebe { get; set; }
	}
}
