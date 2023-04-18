using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mandala.Models
{
    public class User
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public int Phone { get; set; }
        public string? UserAddress { get; set; }

        [Required]
        public string Password { get; set; } = null!;

        [ForeignKey("ComputerId")]
        public Guid ComputerId { get; set; }
        public Computer Computer { get; set; } = null!;

        [ForeignKey("RoleId")]
        public Guid RoleId { get; set; }
        public Role Role { get; set; } = null!;
    }
}