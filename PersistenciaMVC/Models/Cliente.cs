using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersistenciaMVC.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Nome:")]
        [StringLength(30)]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Telefone:")]
        public int telefone { get; set; }
    }
}
