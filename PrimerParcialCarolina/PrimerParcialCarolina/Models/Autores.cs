using System.ComponentModel.DataAnnotations;

namespace PrimerParcialCarolina.Models
{
    public partial class Autores
    {
        [Key]
        public int AutorId { get; set; }
        
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombres { get; set; } = string.Empty;
        public string Nacionalidad { get; set; } = string.Empty;
        public DateOnly FechaNacimiento { get; set; }
        
        [Range(1,double.MaxValue,ErrorMessage ="El sueldo debe ser mayor a 0")]
        public double Sueldo { get; set; }
    }
}
