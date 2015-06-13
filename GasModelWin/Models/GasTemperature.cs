using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasModelWin.Models
{
    class GasTemperature
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
