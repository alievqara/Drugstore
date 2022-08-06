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
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "6 -  Sale.");
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
                                        if ((numberDrugstoreMenu >= 0 && numberDrugstoreMenu <= 6) || numberDrugstoreMenu == 9)
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
                                                    _drugstoreControllers.Update();
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
                                                    _drugstoreControllers.GetDrugstoreByOwner();
                                                    goto DrugstoreMenu;
                                                    break;
                                                case (int)OptionsDrugstore.Sale:
                                                    _drugstoreControllers.Sale();
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

                                #region Druggist Menu

                                case (int)OptionsMenu.DruggistMenu:
                                DruggistMenu: ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Menu");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "1 -  Add Druggist.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "2 -  Update Druggist.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "3 -  Delete Druggist.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "4 -  Get All Druggist List.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "5 -  Get Drugstore Druggist List.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "9 -  Back...");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "0 -  Logout User Account...");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Select option: ");
                                    string numberDruggist = Console.ReadLine();
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    int numberDruggistMenu;
                                    result = int.TryParse(numberDruggist, out numberDruggistMenu);
                                    if (result)
                                    {
                                        if ((numberDruggistMenu >= 0 && numberDruggistMenu <= 5) || numberDruggistMenu == 9)
                                        {
                                            switch (numberDruggistMenu)
                                            {
                                                case (int)OptionsMenu.Logout:
                                                    _userControllers.Logout();
                                                    goto Authentication;
                                                    break;
                                                case (int)OptionsMenu.Back:
                                                    goto ParameterizedThreadStart;
                                                    break;
                                                case (int)OptionsDruggist.AddDruggist:


                                                    goto DruggistMenu;
                                                    break;
                                                case (int)OptionsDruggist.UpdateDruggist:

                                                    goto DruggistMenu;
                                                    break;
                                                case (int)OptionsDruggist.DeleteDruggist:

                                                    goto DruggistMenu;
                                                    break;
                                                case (int)OptionsDruggist.GetAllDruggist:

                                                    goto DruggistMenu;
                                                    break;
                                                case (int)OptionsDruggist.GetDruggistByDrugstore:
                                                    
                                                    goto DruggistMenu;
                                                    break;
                                              
                                            }
                                        }
                                        else
                                        {
                                            ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "<<< Please Select Correct Options. >>>");
                                            goto DruggistMenu;

                                        }

                                    }
                                    else
                                    {
                                        ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "<<< Please Write Correct Format Options. >>>");
                                        goto DruggistMenu;
                                    }
                                    break;

                                #endregion

                                #region Drug Menu

                                case (int)OptionsMenu.DrugMenu:
                                DrugMenu: ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Menu");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "1 -  Create Drug.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "2 -  Update Drug.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "3 -  Delete Drug.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "4 -  Get All Drugs List.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "5 -  Get Drugstore Drugs List.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "6 -  Filter.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "9 -  Back...");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "0 -  Logout User Account...");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Select option: ");
                                    string numberDrug = Console.ReadLine();
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    int numberDrugMenu;
                                    result = int.TryParse(numberDrug, out numberDrugMenu);
                                    if (result)
                                    {
                                        if ((numberDrugMenu >= 0 && numberDrugMenu <= 6) || numberDrugMenu == 9)
                                        {
                                            switch (numberDrugMenu)
                                            {
                                                case (int)OptionsMenu.Logout:
                                                    _userControllers.Logout();
                                                    goto Authentication;
                                                    break;
                                                case (int)OptionsMenu.Back:
                                                    goto ParameterizedThreadStart;
                                                    break;
                                                case (int)OptionsDrug.CreateDrug:


                                                    goto DrugMenu;
                                                    break;
                                                case (int)OptionsDrug.UpdateDrug:

                                                    goto DrugMenu;
                                                    break;
                                                case (int)OptionsDrug.DeleteDrug:

                                                    goto DrugMenu;
                                                    break;
                                                case (int)OptionsDrug.GetAllDrugs:

                                                    goto DrugMenu;
                                                    break;
                                                case (int)OptionsDrug.GetDrugsDrugstores:

                                                    goto DrugMenu;
                                                    break;
                                                case (int)OptionsDrug.Filter:

                                                    goto DrugMenu;
                                                    break;

                                            }
                                        }
                                        else
                                        {
                                            ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "<<< Please Select Correct Options. >>>");
                                            goto DrugMenu;

                                        }

                                    }
                                    else
                                    {
                                        ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "<<< Please Write Correct Format Options. >>>");
                                        goto DrugMenu;
                                    }
                                    break;

                                #endregion

                                #region User

                                case (int)OptionsMenu.UserMenu:
                                UserMenu: ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Menu");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "1 -  Create New User.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "2 -  Delete User Drug.");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "9 -  Back...");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.White, "0 -  Logout User Account...");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Select option: ");
                                    string numberUser = Console.ReadLine();
                                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "------------------------------------------------------------------------------------");
                                    int numberUserMenu;
                                    result = int.TryParse(numberUser, out numberUserMenu);
                                    if (result)
                                    {
                                        if ((numberUserMenu >= 0 && numberUserMenu <= 2) || numberUserMenu == 9)
                                        {
                                            switch (numberUserMenu)
                                            {
                                                case (int)OptionsMenu.Logout:
                                                    _userControllers.Logout();
                                                    goto Authentication;
                                                    break;
                                                case (int)OptionsMenu.Back:
                                                    goto ParameterizedThreadStart;
                                                    break;
                                                case (int)OptionsUser.CreateUser:


                                                    goto UserMenu;
                                                    break;
                                              
                                                case (int)OptionsUser.DeleteUser:

                                                    goto UserMenu;
                                                    break;
                                                

                                            }
                                        }
                                        else
                                        {
                                            ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "<<< Please Select Correct Options. >>>");
                                            goto DrugMenu;

                                        }

                                    }
                                    else
                                    {
                                        ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "<<< Please Write Correct Format Options. >>>");
                                        goto DrugMenu;
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
