using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Profession
    {
        private static List<ProfessionItems> professions = new List<ProfessionItems>() {
            new ProfessionItems{ Id = 1, Name = "Developer" },
            new ProfessionItems{Id = 2, Name = "Asbaz" },
            new ProfessionItems{Id = 3, Name = "Menecer"}
        };
        public static List<ProfessionItems> GetAllProfessions()
        {
            return professions;
        }
    }
    public class ProfessionItems
    {
        public int Id { get; set; }
        public string Name { get; set; }

       
    }
}
