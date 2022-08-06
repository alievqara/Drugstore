using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Constants
{
    public class Constants
    {
        public enum OptionsMenu
        {

            Logout = 0,
            OwnerMenu = 1,
            DrugstoreMenu = 2,
            DruggistMenu = 3,
            DrugMenu = 4,
            UserMenu = 5,
            Back = 9,


        }
        public enum OptionsOwner
        {

            AddOwner = 1,
            UpdateOwner = 2,
            DeleteOwner = 3,
            GetAllOwner = 4,

        }

        public enum OptionsDrugstore
        {
            CreateDrugstore = 1,
            UpdateDrugstore = 2,
            DeleteDrugstore = 3,
            GetAllDrugstore = 4,
            GetDrugstoreByOwner=5,
            Sale = 6,

        }

        public enum OptionsDruggist
        {
            AddDruggist = 1,
            UpdateDruggist = 2,
            DeleteDruggist = 3,
            GetAllDruggist = 4,
            GetDruggistByDrugstore = 5,
            

        }

        public enum OptionsDrug
        {
            CreateDrug = 1,
            UpdateDrug = 2,
            DeleteDrug = 3,
            GetAllDrugs = 4,
            GetDrugsDrugstores = 5,
            Filter = 6,


        }

        public enum OptionsUser
        {
            CreateUser = 1,
            DeleteUser = 2,
        }        }


    }
}
