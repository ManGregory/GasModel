using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasModelWin.Models
{
    class Result
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int ModelingType { get; set; }

        [Required]
        public decimal GasVolume { get; set; }

        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [Required]
        public int GasId { get; set; }
        [Required]
        [ForeignKey("GasId")]
        public virtual Gas Gas { get; set; }

        [Required]
        public decimal GasTemperature { get; set; }

        [Required]
        public decimal EnvironmentPressure1 { get; set; }

        [Required]
        public decimal EnvironmentPressure2 { get; set; }

        [Required]
        public decimal ModelingResult { get; set; }

        public const decimal R = 8.3144621m;

        public static decimal Calc(Result result, decimal cp, decimal a, decimal b,
            decimal p1, decimal p2)
        {
            return result.ModelingType == 1
                ? ((R*result.GasTemperature*(b/(result.GasVolume - b))) - ((2*a)/result.GasVolume))/(cp + R)
                : (((p2 - p1)*((2*a)/(R*result.GasTemperature)) - b)/cp);
        }
    }
}
