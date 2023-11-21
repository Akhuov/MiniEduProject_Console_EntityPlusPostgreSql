
namespace Lesson28.Models
{
    public class Group : IName
    {
        public Group()
        {

        }

        public Group(string name)
        {
            this.Name = name;
        }

        [Key]
        public Guid GroupId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
