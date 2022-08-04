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
    public class DrugstoreControllers
    {
        OwnerRepository _ownerRepository;
        DrugstoreRepository _drugstoreRepository;

        public DrugstoreControllers()
        {
            _ownerRepository = new OwnerRepository();
            _drugstoreRepository = new DrugstoreRepository();
        }

        #region Create Drugstore

        public void CreateDrugstore()
        {
            var owners = _ownerRepository.GetAll();
            if (owners.Count > 0)
            {
                ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Pleace Enter Drugstore Name: ");
                string drugstoreName = Console.ReadLine();
                ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Pleace Enter Drugstore Address: ");
                string drugstoreAddress = Console.ReadLine();
                ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Pleace Enter Drugstore Contact Number: ");
                string drugstoreContactNumber = Console.ReadLine();
            selectedOwnerID:
                foreach (var owner in owners)
                {
                    if (owner != null)
                    {
                        ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, $"ID: {owner.ID}, FullName: {owner.Name} {owner.Surname}");
                    }
                    else
                    {
                        ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "This Owners Doesn't Exist...");
                        goto selectedOwnerID;

                    }
                }
                ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Pleace Select Drugstore Owner ID: ");
                string ownerId = Console.ReadLine();
                int selectedOwnerID;
                bool result = int.TryParse(ownerId, out selectedOwnerID);

                if (result)
                {
                    if (owners != null)
                    {
                        var owner = _ownerRepository.Get(o => o.ID == selectedOwnerID);
                        Drugstore drugstore = new Drugstore
                        {
                            NameDrugstore = drugstoreName,
                            Address = drugstoreAddress,
                            ContactNumber = drugstoreContactNumber,
                            ownerDrugstore = owner


                        };

                        _drugstoreRepository.Create(drugstore);
                        ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, $"Drugstore Successfully Created. Drugstore Information:" +
                        $"ID: {drugstore.ID}, Name: {drugstore.NameDrugstore}, Address: {drugstore.Address}," +
                        $" Contact Number: {drugstore.ContactNumber}, Owner Drugstore: {drugstore.ownerDrugstore.Name} {drugstore.ownerDrugstore.Surname}");
                    }
                    else
                    {
                        ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "This Owners Doesn't Exist...");
                        goto selectedOwnerID;
                    }


                }
                else
                {
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "This Select Correct Format(number) ID...");
                    goto selectedOwnerID;
                };









                //Elave Olunacaq Satici ve Dermanlaar

            }
            else
            {
                ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "You Can't Create a Drugstore Without Adding Owners ! ");

            }



        }

        #endregion

        #region Update Frugstore
        public void Update()
        {

        }

        #endregion

        #region Detele Drugstore
        public void DeleteDrugstore()
        {
            var drugstores = _drugstoreRepository.GetAll();
        DrugstoreList: ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, "All Drugstore List: ");
            foreach (var drugstore in drugstores)
            {
                if (drugstore != null)
                {
                    var ownerDrugstore = _ownerRepository.Get(o => o.ID == drugstore.ownerDrugstore.ID);
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, $"ID: {drugstore.ID}, Name: {drugstore.NameDrugstore}, Owner Name: {ownerDrugstore.Name} {ownerDrugstore.Surname}");

                }
                else
                {
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "This Drugstore Doesn't Exist...");
                    goto DrugstoreList;
                }
            }
            ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Pleace Select Drugstore ID Number: ");
            string enteredNumber = Console.ReadLine();
            int selectedID;
            bool result = int.TryParse(enteredNumber, out selectedID);
            var deletedDrugstore = _drugstoreRepository.Get(d => d.ID == selectedID);
            if (result)
            {
                if (deletedDrugstore != null)
                {
                    _drugstoreRepository.Delete(deletedDrugstore);
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, $"ID: {deletedDrugstore.ID}, Name: {deletedDrugstore.NameDrugstore} is successfully deleted...");

                }
                else
                {
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "This Drugstore Doesn't Exist...");
                    goto DrugstoreList;
                }

            }
            else
            {
                ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "Pleace Write ID Number Correct Format...");
                goto DrugstoreList;
            }


        }

        #endregion

        #region Get All Drugstore

        public void GetAllDrugstores()
        {
            var drugstores = _drugstoreRepository.GetAll();
            ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, "All Drugstores List: ");
            foreach (var drugstore in drugstores)
            {
                if (drugstore != null)
                {

                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, $"ID: {drugstore.ID}, Full Information: {drugstore.NameDrugstore} {drugstore.Address}  {drugstore.ContactNumber}. Owner: {drugstore.ownerDrugstore.Name}  {drugstore.ownerDrugstore.Surname}");
                }
                else
                {
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "The owner does not have a Drugstore...");

                }





            }
        }

        #endregion

        #region Get Drugstore By Owner

        public void GetDrugstoreByOwner()
        {
            var owners = _ownerRepository.GetAll();
            var drugstores = _drugstoreRepository.GetAll();
            ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "All Owners List:");
            foreach (var owner1 in owners)
            {
                if (owner1 != null)
                {
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, $"ID: {owner1.ID},  Owner: {owner1.Name}  {owner1.Surname}.");

                }
                else
                {
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "Owner does not System...");

                }
            }
            ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkGreen, "Pleace Select Owner ID Number...");
            string selectedNumber = Console.ReadLine();
            int selectedId;
        TryIdSelect: bool result = int.TryParse(selectedNumber, out selectedId);
            if (result)
            {
                foreach (var drugstore in drugstores)
                {
                    var owner = _ownerRepository.Get(o => o.ID == drugstore.ownerDrugstore.ID);
                    if (owner != null)
                    {
                        ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, $"Owner: {owner.Name}  {owner.Surname}, Name Drugstore: {drugstore.NameDrugstore}");

                    }
                    else
                    {
                        ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "The owner does not have a Drugstore...");

                    }


                }

            }
            else
            {

                ConsoleHelper.WriteTextWithColor(ConsoleColor.DarkRed, "Pleace Write ID Number Correct Format or Correct Number ...");
                goto TryIdSelect;
            }






        }

        #endregion

        #region Sale

        public void Sale()
        {

        }

        #endregion
    }
}
