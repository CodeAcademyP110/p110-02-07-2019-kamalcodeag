using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Group
    {
        private static List<GroupItem> groups = new List<GroupItem>() {
            new GroupItem{ Id = 1, Name = "Group1"  },
            new GroupItem{Id = 2, Name = "Group2"  },
            new GroupItem{Id = 3, Name = "Group3"  }
        };

        public static List<GroupItem> GetAllGroups()
        {
            return groups;
        }
    }

    public class GroupItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
