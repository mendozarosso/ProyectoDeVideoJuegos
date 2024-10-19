using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoDeVideoJuegos.Data
{
    public class VideoJuego
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El desarrollador es obligatorio")]
        public string Desarrollador { get; set; }

        [Required(ErrorMessage = "La plataforma es obligatoria")]
        public int PlataformaId { get; set; }
        public Plataforma Plataforma { get; set; }

        [Required(ErrorMessage = "El género es obligatorio")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "La fecha de lanzamiento es obligatoria")]
        public DateTime FechaLanzamiento { get; set; }

        public string ImagenPortada { get; set; }

        public string Descripcion { get; set; }
    }
}