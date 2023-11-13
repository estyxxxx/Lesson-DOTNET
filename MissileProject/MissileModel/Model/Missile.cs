using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MissileModel.Model
{
    [Table("Missiles")]
    public class Missile
    {
        [Key]
        [Required]
        public string id { get; set; }
        [MaxLength(50)]
        public Location location { get; set; }
    }
}