using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAS901_Desafio2.Models
{
    public class Genero
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Required]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)"), MaxLength(50), Required]
        [DisplayName("Genero")]
        public string NombreGenero { get; set; }
    }
}
