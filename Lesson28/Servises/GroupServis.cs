using Lesson28.Interfaces.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson28.Servis
{
    public class GroupServis:IGroupServis
    {
        public  void AddGroup(string groupName)
        {
            var db = new EduCenterDB();
            var group = new Group(groupName);
            db.Add(group);
            db.SaveChanges();
        }
        public  Group GetGroup(string groupName)
        {
            var db = new EduCenterDB();
            var group = db.Groups.FirstOrDefault(student => student.Name.Equals(groupName));
            return group;
        }
        public  void GetGroupMembers(string groupName)
        {
            var db = new EduCenterDB();
            var groupMembers = db.GroupMembers.Where(student => student.Group.Name.Equals(groupName))
                .Select(member => new StudentViewModel()
                {
                    FirstName = member.Student.FirstName,
                    LastName = member.Student.LastName,
                    StudentId = member.Student.StudentId,
                }).ToList();

            var groupMembersSQL = db.GroupMembers.Where(student => student.Group.Name.Equals(groupName))
                .Select(member => new StudentViewModel()
                {
                    FirstName = member.Student.FirstName,
                    LastName = member.Student.LastName,
                    StudentId = member.Student.StudentId,
                }).ToQueryString();

            foreach (var groupMember in groupMembers)
            {
                Console.WriteLine($"{groupMember.FirstName}-{groupMember.LastName}");
            }
        }
    }
}
