using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace examen_U2.Database.Entities
{
    [Table("clientes", Schema = "dbo")]
    public class ClienteEntity : BaseEntity
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El {0} del cliente es requerido.")]
        [StringLength(50)]
        [Column("name")]
        public string name { get; set; }

        [Required(ErrorMessage ="El {0} es requerido")]
        public string loanAmount { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        public string commissionRate { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        public string interestRate { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        public string term { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        public DateTime disbursementDate { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        public DateTime firstPaymentDate { get; set; }
    }
}
