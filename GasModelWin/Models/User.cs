using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GasModelWin.Models
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string Patronymic { get; set; }

        [StringLength(50)]
        public string Office { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Name, Surname);
        }
    }
}
