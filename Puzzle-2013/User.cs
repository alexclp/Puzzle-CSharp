using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puzzle_2013
{
    public class User
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int userType { get; set; }

        public static User CreateUser(int id, string name, string surname, string username, string password, int type)
        {
            User user = new User();

            user.ID = id;
            user.name = name;
            user.surname = surname;
            user.password = password;
            user.userType = type;

            return user;
        }
    }
}
