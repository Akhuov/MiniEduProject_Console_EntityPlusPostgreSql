
namespace Lesson28.Models
{
    public class Teacher : IPerson
    {
        [Key]
        public Guid TeacherId { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
