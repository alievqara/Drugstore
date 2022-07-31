using Core.Entities;
using Core.Helpers;
using DataBase.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage.Controllers
{
    public class UserControllers
    {

        private UserRepository _userRepository;

        public UserControllers()
        {
            _userRepository = new UserRepository();
        }

        public User Autenticate()
        {

            ConsoleHelper.WriteTextWithColor(ConsoleColor.Green, "Enter Username:");
            string username = Console.ReadLine();
            ConsoleHelper.WriteTextWithColor(ConsoleColor.Green, "Enter Password:");
            string password = Console.ReadLine();

            var user = _userRepository.Get(u => u.Username.ToLower() == username.ToLower() && PasswordsHashers.Decrypt(u.Password) == password);
            return user;


        }
        public void Logout()
        {

            ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "Good Days");

        }

        public void Back()
        {
        }

    }
}
