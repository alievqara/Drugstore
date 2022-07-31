using Core.Entities;
using Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Context
{
    public static class DataBaseContext
    {
        public static List<User> Users { get; set; }
        public static List<Owner> Owners { get; set; }


        static DataBaseContext()
        {
            Owners = new List<Owner>();
            Users = new List<User>();


            string defaultUser = "admin";
            string password = "admin";

            string defaultUser1 = "user";
            string password1 = "user";

            var encryptPassword = PasswordsHashers.Encrypt(password);

            var user = new User(defaultUser, encryptPassword);
            Users.Add(user);

        }

    }
}
