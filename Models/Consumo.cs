using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace microfundamento_web_backend.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de Descrição é obrigatório!")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo de Data é obrigatório!")]
        public DateTime Data { get; set; }
        [Required(ErrorMessage = "O campo de Valor é obrigatório!")]
        public decimal Valor { get; set; }
        [Required(ErrorMessage = "O campo de Quilometragem é obrigatório!")]
        public int Km { get; set; }
        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel Tipo { get; set; }
        [Display(Name = "Veiculo")]
        [Required(ErrorMessage = "O campo de Veículo é obrigatório!")]
        public int VeiculoId { get; set; }
        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
}
