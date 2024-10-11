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
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "O campo de Ano do Modelo é obrigatório!")]
        public int AnoModelo { get; set; }
        public int AnoServicio { get; set; }

    }
}
