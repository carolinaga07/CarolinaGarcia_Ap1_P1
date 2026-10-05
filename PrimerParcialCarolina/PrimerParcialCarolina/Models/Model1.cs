using System.ComponentModel.DataAnnotations;

namespace PrimerParcialCarolina.Models
{
    public partial class Model1
    {
        [Key]
        public int MyProperty { get; set; }
        public object ModelId { get; internal set; }
    }
}
