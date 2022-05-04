using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DAS901_Desafio2.Models
{
    public class Contacto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Required]
        public int Id { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail no válido")]
        [Column(TypeName = "varchar(100)"), MaxLength(100), Required]
        [DisplayName("Dirección de Correo")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(100)"), MaxLength(100), Required]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(100)"), Required]
        [DisplayName("Asunto")]
        public string Asunto { get; set; }
        [Column(TypeName = "text"), Required]
        [DisplayName("Mensaje")]
        public string Mensaje { get; set; }

        [DisplayName("Fecha de Creación")]
        public DateTime Fecha { get; set; }
        [DefaultValue(true)]
        public bool Activo { get; set; }
    }
}
