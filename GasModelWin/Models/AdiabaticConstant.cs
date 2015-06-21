using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GasModelWin.Models
{
    /// <summary>
    /// Адиабатная константа
    /// </summary>
    public class AdiabaticConstant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int GasId { get; set; }
        [Required]
        [ForeignKey("GasId")]
        public virtual Gas Gas { get; set; }

        [Required]
        public decimal K { get; set; }
    }
}
