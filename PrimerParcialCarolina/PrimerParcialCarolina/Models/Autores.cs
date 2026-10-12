using System.ComponentModel.DataAnnotations;

namespace PrimerParcialCarolina.Models
{
    public partial class Autores
    {
        [Key]
        public int AutorId { get; set; }
        
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombres { get; set; } = string.Empty;

        [Required(ErrorMessage = "La nacionalida es obligatoria")]
        public string Nacionalidad { get; set; } = string.Empty;

        [Range(typeof(DateOnly), "1900-01-01", "2100-01-01", ErrorMessage =" la fecha de nacimiento es obligatoria")]
        public DateOnly FechaNacimiento { get; set; }
        
        [Range(1,double.MaxValue,ErrorMessage ="El sueldo debe ser mayor a 0")]
        public double Sueldo { get; set; }
    }
}
