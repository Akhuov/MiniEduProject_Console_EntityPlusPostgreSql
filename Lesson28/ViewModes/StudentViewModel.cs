
namespace Lesson28.ViewModes
{
    internal class StudentViewModel : IPerson
    {
        public Guid? StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
