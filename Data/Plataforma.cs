using System.ComponentModel.DataAnnotations;

namespace ProyectoDeVideoJuegos.Data
{
    public class Plataforma
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la plataforma es obligatorio")]
        public string Nombre { get; set; }

        public bool Estado { get; set; } = true;
    }
}