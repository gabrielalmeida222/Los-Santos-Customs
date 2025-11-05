using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Los_Santos_Customs.Models
{
    public class Peca
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Por favor, informe o nome da peça")]
        public string Nome { get; set; }

        public string Medida { get; set; }

        public string Cor { get; set; }

        

    }
}