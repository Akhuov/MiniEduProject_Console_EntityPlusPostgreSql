using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson28.Interfaces.Servises
{
    public interface IStudentServis
    {
        public void AddStudent(Student student);
        public void GetSudents();
        public Student GetStudentByUserName(string username);
    }
}
