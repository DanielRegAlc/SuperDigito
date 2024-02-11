using System.ComponentModel.DataAnnotations;

namespace SuperDigito.Models
{
    public class Login
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "El usuario es obligatorio")]
        public string User { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Password { get; set; }
        public ICollection<History> Histories { get; set; }
    }
}
