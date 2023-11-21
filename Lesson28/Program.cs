
string groupName = ".NET Group";

// AddGroup(groupName);
// AddStudent(student);
// Console.WriteLine("Done");
// GetSudents();
// string userName = Console.ReadLine();
// var student = GetStudentByUserName(userName);
// var group = GetGroup(groupName);
// if (student != null && group != null)
// {
//     EnrollMember(groupId: group.GroupId, studentId: student.StudentId);
// }


var r = new SeedData();







void EnrollMember(Guid studentId, Guid groupId)
{
    var db = new EduCenterDB();
    var member = new GroupMember()
    {
        GroupId = groupId,
        StudentId = studentId,
    };
    db.Add(member);
    db.SaveChanges();
}





