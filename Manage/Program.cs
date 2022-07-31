using Core.Helpers;
using Manage.Controllers;
using System;
using static Core.Constants.Constants;

namespace Manage
{
    public class Program
    {
        public static void Main()
        {

            UserControllers _userControllers = new UserControllers();

            ConsoleHelper.WriteTextWithColor(ConsoleColor.Green, "Welcome to Drugstore System");

            Console.WriteLine("------------------------------------------------------------------------------------");
        Authentication: var user = _userControllers.Autenticate();
            if (user != null)
            {
                while (true)
                {
                ParameterizedThreadStart:
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Menu");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "1 -  For Owner Menu");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "2 -  For Drugstore Menu");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "3 -  For Druggist Menu");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "4 -  For Drug Menu");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "5 -  For Users Menu");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "0 -  Logout");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Select option: ");
                    string number = Console.ReadLine();
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                    int menuNumber;
                    bool result = int.TryParse(number, out menuNumber);
                    if (result)
                    {
                        if (menuNumber >= 0 && menuNumber <= 5)
                        {
                            switch (menuNumber)
                            {
                                case (int)OptionsMenu.Logout:
                                    _userControllers.Logout();
                                    goto Authentication;
                                    break;
                             
                                
                            }
                        }
                        else
                        {
                            ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "<<< Please Select Correct Options. >>>");
                            goto ParameterizedThreadStart;
                        }
                    }
                }
            }
            else
            {
                ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "<<< Please Select Correct Password or Username >>>");
                goto Authentication;
            }

        }
    }
}
