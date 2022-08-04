using Core.Entities;
using DataBase.Context;
using DataBase.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositories.Implementations
{
    public class DrugstoreRepository : IRepositories<Drugstore>
    {
        private static int id;
        public Drugstore Create(Drugstore entity)
        {
            id++;
            entity.ID = id;
            DataBaseContext.Drugstores.Add(entity);
            return entity;
        }

        public void Delete(Drugstore entity)
        {
            DataBaseContext.Drugstores.Remove(entity);
        }

        public Drugstore Get(Predicate<Drugstore> filter)
        {
            if (filter == null)
            {
                return DataBaseContext.Drugstores[0];
            }
            else
            {
                return DataBaseContext.Drugstores.Find(filter);
            }
        }

        public List<Drugstore> GetAll(Predicate<Drugstore> filter = null)
        {
            if (filter == null)
            {
                return DataBaseContext.Drugstores;
            }
            else
            {
                return DataBaseContext.Drugstores.FindAll(filter);
            }
        }

        public Drugstore Update(Drugstore entity)
        {
            var drugstores = DataBaseContext.Drugstores.Find(d => d.ID == entity.ID);
            if (drugstores!=null)
            {
                drugstores.NameDrugstore = entity.NameDrugstore;
                drugstores.Address = entity.Address;
                drugstores.ContactNumber = entity.ContactNumber;
                drugstores.ownerDrugstore = entity.ownerDrugstore;
            }
            return drugstores;
        }
    }
}
