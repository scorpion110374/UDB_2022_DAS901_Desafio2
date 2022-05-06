using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAS901_Desafio2.Models
{
    public class Calificacion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Required]
        public int Id { get; set; }
        [DisplayName("Id Película")]
        public int IdPelicula { get; set; }
        [DisplayName("Id Usuario")]
        public int? idUsuario { get; set; }
        [DisplayName("Fecha")]
        public DateTime Fecha { get; set; }
        [DefaultValue(0)]
        [DisplayName("Calificación")]
        public int CalificacionPelicula { get; set; }

        [ForeignKey("IdPelicula ")]
        public Pelicula Pelicula { get; set; }
    }
}
