using System.ComponentModel.DataAnnotations;

namespace Mandala.Models
{
    public class Classroom
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string ClassroomName { get; set; } = null!;
        public int ClassroomNumber { get; set; }
        public IEnumerable<Computer> Computers { get; set; } = Enumerable.Empty<Computer>();
    }
}