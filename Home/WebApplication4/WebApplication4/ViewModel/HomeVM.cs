using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.ViewModel
{
    public class HomeVM
    {
        public IEnumerable<StudentItem> Students { get; set; }

        public IEnumerable<ProfessionItems> Professions { get; set; }

        public IEnumerable<GroupItem> Groups { get; set; }
    }
}
