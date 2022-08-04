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
    public class OwnerControllers
    {
        private OwnerRepository _ownerRepository;

        public OwnerControllers()
        {
            _ownerRepository = new OwnerRepository();
        }

        #region AddOwnerRegion

        public void AddOwner()
        {
        CreatedOwner:
            ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Pleace Enter Owner Name: ");
            string ownerName = Console.ReadLine();
            ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Pleace Enter Owner Surname: ");
            string ownerSurname = Console.ReadLine();
            ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Pleace Enter Owner Age: ");
            string age = Console.ReadLine();
            byte ownerAge;
            bool result = byte.TryParse(age, out ownerAge);
            if (result)
            {
                Owner owner = new Owner
                {
                    Name = ownerName,
                    Surname = ownerSurname,
                    Age = ownerAge
                };
                var createdOwner = _ownerRepository.Create(owner);
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, $"{owner.Name} {owner.Surname} is successfully added system.");

            }
            else
            {
                ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "Pleace Enter Correct Format Owner Information.(Name,Surname,Age)");
                goto CreatedOwner;
            }

        }

        #endregion

        #region UpdateOwner
        public void UpdateOwner()
        {
            var owners = _ownerRepository.GetAll();
        OwnerList: ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, "All Owners List: ");
            foreach (var ownr in owners)
            {
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, $"ID: {ownr.ID}, FullName: {ownr.Name} {ownr.Surname}");
            }
        TryIdSelect: ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Pleace Select Owner ID Number: ");
            string enteredNumber = Console.ReadLine();
            int selectedID;
            bool result = int.TryParse(enteredNumber, out selectedID);
            var owner = _ownerRepository.Get(o => o.ID == selectedID);
            if (owner != null)
            {
            TryUpdate: ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Pleace Enter New Owner Name...");
                string name = Console.ReadLine();
                ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Pleace Enter New Owner Surname...");
                string surname = Console.ReadLine();
                ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Pleace Enter New Owner Age...");
                string agestring = Console.ReadLine();
                byte newage;
                result = byte.TryParse(agestring, out newage);
                if (result)
                {
                    var updatedOwner = new Owner();
                    {
                        owner.ID = updatedOwner.ID;
                        owner.Name = updatedOwner.Name;
                        owner.Surname = updatedOwner.Surname;
                        newage = updatedOwner.Age;
                        ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, $"Informations: {owner.Name} {owner.Surname} {owner.Age} is successfully updated to {updatedOwner.Name} {updatedOwner.Surname} {updatedOwner.Age}");

                    }
                }
                else
                {
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "Pleace Enter Correct Format Owner Information.(Name,Surname,Age)");
                    goto TryUpdate;
                }

            }
            else
            {
                ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "Pleace Write ID Number Correct Format or Correct Number ...");
                goto TryIdSelect;
            }


        }

        #endregion

        #region DeleteOwner
        public void DeleteOwner()
        {
            var owners = _ownerRepository.GetAll();
        OwnerList: ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, "All Owners List: ");
            foreach (var ownr in owners)
            {
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, $"ID: {ownr.ID}, FullName: {ownr.Name} {ownr.Surname}");
            }
            ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Pleace Select Owner ID Number: ");
            string enteredNumber = Console.ReadLine();
            int selectedID;
            bool result = int.TryParse(enteredNumber, out selectedID);
            var owner = _ownerRepository.Get(o => o.ID == selectedID);
            if (result)
            {
                if (owner != null)
                {
                    _ownerRepository.Delete(owner);
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, $"ID: {owner.ID}, FullName: {owner.Name} {owner.Surname} is successfully deleted...");

                }
                else
                {
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "This Owners Doesn't Exist...");
                    goto OwnerList;
                }
            }
            else
            {
                ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "Pleace Write ID Number Correct Format...");
            }
        }


        #endregion

        #region GetAllOwners

        public void GetAllOwners()
        {
            var owners = _ownerRepository.GetAll();
            ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, "All Owners List: ");
            foreach (var owner in owners)
            {
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, $"ID: {owner.ID}, FullName: {owner.Name} {owner.Surname}");
            }
        }

        #endregion
    }
}
