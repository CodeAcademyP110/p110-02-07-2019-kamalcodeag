using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Models
{
    public static class UserBox
    {
        private static List<string> users = new List<string>()
        {
            "ali","baba"
        };

        public static List<string> GetUsers() => users;
    }
}
