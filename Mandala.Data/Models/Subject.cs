using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mandala.Models
{
    public class Subject
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string SubjectName { get; set; } = null!;
        public string TeacherName { get; set; } = null!;
        [ForeignKey("ComputerId")]
        public Guid ComputerId { get; set; }
        public Computer Computer { get; set; } = null!;
    }
}