

namespace Lesson28.Models
{
    public class Subject : IName, IDesciption
    {
        [Key]
        public Guid SubjectId { get; set; }

        [Column(Order = 2)]
        public string Description { get; set; }

        [MaxLength(100)]
        [Column("SubjectName", Order = 1)]
        public string Name { get; set; }
    }
}
