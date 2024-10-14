using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace microfundamento_web_backend.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de Nome é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo de Placa é obrigatório!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "O campo de Ano de Fabricação é obrigatório!")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "O campo de Ano do Modelo é obrigatório!")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }
    }
}
