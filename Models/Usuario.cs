using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace microfundamento_web_backend.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de Nome é obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo de Senha é obrigatório!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required(ErrorMessage = "O campo de Perfil é obrigatório!")]
        public Perfil Perfil { get; set; }
    }
}
public enum Perfil
{
    Admin,
    User
}