using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoParts.Models
{
    [Table("PecaTipo")]
    public class PecaVeiculo
    {
        [Key, Column(Order = 1)]
        public int PecaId { get; set; }
        [ForeignKey("PecaId")]
        public Peca Peca { get; set; }

        [Key, Column(Order = 2)]
        public int VeiculoId { get; set; }
        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }
}
