using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVeterinaria.Models
{
    [Table("Turno")]
    public class Turno
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        [Column(TypeName = "time")]
        public TimeSpan Hora { get; set; }

        [Required]
        [MaxLength(50)]
        public string NombreMascota { get; set; }

        public TipoMascota TipoMascota { get; set; }

        [MaxLength(50)]
        public string Raza { get; set; }


        public int Edad { get; set; }

        [Required]
        [MaxLength(50)]
        public string NombreDuenio { get; set; }

        [Required]
        [MaxLength(15)]
        public string Celular { get; set; }

    }
}
