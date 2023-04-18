using Student.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Student.DataAccess
{
    public static class Data
    {
        public static List<Groups> Groups = new List<Groups>()
        {
                new Groups{ Id = 1,Name = "P328"},
                new Groups{ Id = 2,Name = "P329"},
                new Groups{ Id = 3,Name = "P330"},
                new Groups{ Id = 4,Name = "P331"},
                new Groups{ Id = 5,Name = "P332"},

        };

        public static List<Students> Students = new List<Students>()
        {
            new Students { Id = 1, FullName = "Kenan Rehimov", Point = 100 },
            new Students { Id = 2, FullName = "Samir Memmedov", Point = 98 },
            new Students { Id = 3, FullName = "Yusif Memmedov", Point = 99 },
            new Students { Id = 4, FullName = "Ekber Memmedov", Point = 90 },


        };


    }
}
