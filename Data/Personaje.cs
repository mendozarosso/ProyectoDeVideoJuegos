using System.ComponentModel.DataAnnotations;

namespace ProyectoDeVideoJuegos.Data
{
    public class Personaje
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        public string Alias { get; set; }

        [Required(ErrorMessage = "El rol en el juego es obligatorio")]
        public string RolEnJuego { get; set; }

        public string HabilidadEspecial { get; set; }

        public string ArmaFavorita { get; set; }

        [Range(1, 100, ErrorMessage = "El nivel de poder debe estar entre 1 y 100")]
        public int NivelDePoder { get; set; }

        public string ImagenPersonaje { get; set; }

        [Required(ErrorMessage = "El videojuego asociado es obligatorio")]
        public int VideoJuegoId { get; set; }
        public VideoJuego VideoJuego { get; set; }
    }
}