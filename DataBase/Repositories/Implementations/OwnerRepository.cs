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
    public class OwnerRepository : IRepositories<Owner>
    {
        private static int id;
        public Owner Create(Owner entity)
        {
            id++;
            entity.ID = id;
            DataBaseContext.Owners.Add(entity);
            return entity;
        }
        public Owner Update(Owner entity)
        {
            var owners = DataBaseContext.Owners.Find(o => o.ID == entity.ID);
            if (owners != null)
            {
                owners.Name = entity.Name;
                owners.Surname = entity.Name;
                owners.Age = entity.Age;
                owners.drugstores = entity.drugstores;
            }
            return owners;
        }

        public void Delete(Owner entity)
        {
            DataBaseContext.Owners.Remove(entity);      
        }

        public List<Owner> GetAll(Predicate<Owner> filter = null)
        {
            if (filter == null)
            {
                return DataBaseContext.Owners;
            }
            else
            {
                return DataBaseContext.Owners.FindAll(filter);
            }
        }

        public Owner Get(Predicate<Owner> filter)
        {
            if (filter == null)
            {
                return DataBaseContext.Owners[0];
            }
            else
            {
                return DataBaseContext.Owners.Find(filter);
            }
        }
    }
}
