using System;
using System.ComponentModel.DataAnnotations;

namespace VideoClub.Models
{
    public class Pelicula
    {
        public int ID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Director { get; set; }

        [Required]
        public string Genero { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaLanzamiento { get; set; }

        public bool Disponible { get; set; }
    }
}
