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
            OwnerControllers _ownerControllers = new OwnerControllers();
            DrugstoreControllers _drugstoreControllers = new DrugstoreControllers();

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
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "5 -  For Admin Menu");
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "0 -  Logout User Account");
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

                                #region OwnerMenu


                                case (int)OptionsMenu.OwnerMenu:
                                OwnerMenu: ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Menu");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "1 -  Add New Owner.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "2 -  Update Owner.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "3 -  Delete Owner.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "4 -  Get All Owner List.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "9 -  Back...");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "0 -  Logout User Account...");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Select option: ");
                                    string numberOwner = Console.ReadLine();
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    int numberOwnerMenu;
                                    result = int.TryParse(numberOwner, out numberOwnerMenu);
                                    if (result)
                                    {
                                        if ((numberOwnerMenu >= 0 && numberOwnerMenu <= 4) || numberOwnerMenu == 9)
                                        {
                                            switch (numberOwnerMenu)
                                            {
                                                case (int)OptionsMenu.Logout:
                                                    _userControllers.Logout();
                                                    goto Authentication;
                                                    break;
                                                case (int)OptionsMenu.Back:
                                                    goto ParameterizedThreadStart;
                                                    break;
                                                case (int)OptionsOwner.AddOwner:
                                                    _ownerControllers.AddOwner();
                                                    goto OwnerMenu;
                                                    break;
                                                case (int)OptionsOwner.UpdateOwner:
                                                    _ownerControllers.UpdateOwner();
                                                    goto OwnerMenu;
                                                    break;
                                                case (int)OptionsOwner.DeleteOwner:
                                                    _ownerControllers.DeleteOwner();
                                                    goto OwnerMenu;
                                                    break;
                                                case (int)OptionsOwner.GetAllOwner:
                                                    _ownerControllers.GetAllOwners();
                                                    goto OwnerMenu;
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "<<< Please Select Correct Options. >>>");
                                            goto OwnerMenu;
                                        }

                                    }
                                    else
                                    {
                                        ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "<<< Please Write Correct Format Options. >>>");
                                        goto OwnerMenu;
                                    }
                                    break;

                                #endregion

                                #region Drugstore Menu:


                                case (int)OptionsMenu.DrugstoreMenu:
                                DrugstoreMenu: ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Menu");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "1 -  Create Drugstore.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "2 -  Update Drugstore.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "3 -  Delete Drugstore.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "4 -  Get All Drugstore List.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "5 -  Get By Owner Drugstore List.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "9 -  Back...");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "0 -  Logout User Account...");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Select option: ");
                                    string numberDrugstore = Console.ReadLine();
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    int numberDrugstoreMenu;
                                    result = int.TryParse(numberDrugstore, out numberDrugstoreMenu);
                                    if (result)
                                    {
                                        if ((numberDrugstoreMenu >= 0 && numberDrugstoreMenu <= 5) || numberDrugstoreMenu == 9)
                                        {
                                            switch (numberDrugstoreMenu)
                                            {
                                                case (int)OptionsMenu.Logout:
                                                    _userControllers.Logout();
                                                    goto Authentication;
                                                    break;
                                                case (int)OptionsMenu.Back:
                                                    goto ParameterizedThreadStart;
                                                    break;
                                                case (int)OptionsDrugstore.CreateDrugstore:
                                                    _drugstoreControllers.CreateDrugstore();
                                                    goto DrugstoreMenu;
                                                    break;
                                                case (int)OptionsDrugstore.UpdateDrugstore:

                                                    goto DrugstoreMenu;
                                                    break;
                                                case (int)OptionsDrugstore.DeleteDrugstore:
                                                    _drugstoreControllers.DeleteDrugstore();
                                                    goto DrugstoreMenu;
                                                    break;
                                                case (int)OptionsDrugstore.GetAllDrugstore:
                                                    _drugstoreControllers.GetAllDrugstores();
                                                    goto DrugstoreMenu;
                                                    break;
                                                case (int)OptionsDrugstore.GetDrugstoreByOwner:

                                                    goto DrugstoreMenu;
                                                    break;
                                                case (int)OptionsDrugstore.Sale:

                                                    goto DrugstoreMenu;
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "<<< Please Select Correct Options. >>>");
                                            goto DrugstoreMenu;

                                        }

                                    }
                                    else
                                    {
                                        ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "<<< Please Write Correct Format Options. >>>");
                                        goto DrugstoreMenu;
                                    }
                                    break;

                                    #endregion


                            }
                        }
                        else
                        {
                            ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "<<< Please Select Correct Options. >>>");
                            goto ParameterizedThreadStart;
                        }
                    }
                    else
                    {
                        ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "<<< Please Write Correct Format Options. >>>");
                        goto ParameterizedThreadStart;
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
