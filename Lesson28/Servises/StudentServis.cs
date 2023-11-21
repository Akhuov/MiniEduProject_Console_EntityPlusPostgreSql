



namespace Lesson28.Servis
{
    public class StudentServis: IStudentServis
    {
        public void AddStudent(Student student)
        {
            var db = new EduCenterDB();
            db.Add(student);
            db.SaveChanges();
        }
        public void GetSudents()
        {
            var db = new EduCenterDB();
            var students = db.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.UserName}");
            }
        }

        public Student GetStudentByUserName(string username)
        {
            var db = new EduCenterDB();
            var student = db.Students.FirstOrDefault(student => student.UserName.Equals(username));
            return student;
        }
    }
}
