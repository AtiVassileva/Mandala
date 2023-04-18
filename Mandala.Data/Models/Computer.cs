using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mandala.Models
{
    public class Computer
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public bool InternetAccess { get; set; }
        public bool IsAvailable { get; set; }

        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        [ForeignKey("ClassroomId")]
        public Guid ClassroomId { get; set; }
        public Classroom Classroom { get; set; } = null!;

        public IEnumerable<Subject> Subjects { get; set; } = Enumerable.Empty<Subject>();
    }
}