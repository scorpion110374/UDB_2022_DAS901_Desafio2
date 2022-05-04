using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAS901_Desafio2.Models
{
    public class Pelicula
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Required]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)"), MaxLength(50), Required]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(50)"), MaxLength(50), Required]
        [DisplayName("Director")]
        public string Director { get; set; }
        [Column(TypeName = "varchar(100)"), MaxLength(100), Required]
        [DisplayName("Reparto")]
        public string Reparto { get; set; }
        [DisplayName("Genero")]
        public int? IdGenero { get; set; }
        [Column(TypeName = "text"), Required]
        [DisplayName("Sinopsis")]
        public string Sinopsis { get; set; }
        [Column(TypeName = "varchar(100)"), MaxLength(100)]
        [DisplayName("Trailer")]
        public string Trailer { get; set; }
        [DisplayName("Fecha Estreno")]
        public DateTime? FechaEstreno { get; set; }
        [DisplayName("Cartelera")]
        public bool Cartelera { get; set; }
        [DisplayName("Estreno")]
        public bool Estreno { get; set; }
        [DisplayName("Proximamente")]
        public bool Proximamente { get; set; }
        [DefaultValue(true)]
        [DisplayName("Activa")]
        public bool Activa { get; set; }
        [DefaultValue(0)]
        [DisplayName("Calificación")]
        public int Calificacion { get; set; }

        [ForeignKey("IdGenero ")]
        public Genero Genero { get; set; }
    }
}
