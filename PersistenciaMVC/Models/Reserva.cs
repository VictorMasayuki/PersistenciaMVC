using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersistenciaMVC.Models
{
    [Table("Reservas")]
    public class Reserva
    {
        [Key]
        public int id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Nome:")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data:")]
        public DateTime data {  get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Descrição:")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Status:")]
        public char status { get; set; }

    }
}
