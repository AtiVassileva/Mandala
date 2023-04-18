using System.ComponentModel.DataAnnotations;

namespace Mandala.Models
{
    public class Role
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string RoleName { get; set; } = null!;

        [Required]
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
