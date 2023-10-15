using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersistenciaMVC.Models
{
    [Table("Hoteis")]
    public class Hotel
    {
        [Key]
        public int id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Nome do Hotel:")]
        public string nome { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Descricao:")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Datas Disponíveis:")]
        public DateTime data { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Quantidade de hospedes:")]
        public int qtde { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Preço:")]
        public float preco { get; set; }
    }
}
