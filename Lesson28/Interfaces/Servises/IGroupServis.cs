using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson28.Interfaces.Servises
{
    public interface IGroupServis
    {
        public  void AddGroup(string groupName);
        public Group GetGroup(string groupName);
        public  void GetGroupMembers(string groupName);
    }
}
