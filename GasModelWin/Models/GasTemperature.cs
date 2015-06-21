using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GasModelWin.Models
{
    /// <summary>
    /// Температура газа
    /// </summary>
    public class GasTemperature
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
        public decimal Temperature { get; set; }

        [Required]
        public decimal Cp { get; set; }
    }
}
