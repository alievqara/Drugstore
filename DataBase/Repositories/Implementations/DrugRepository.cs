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
    public class DrugRepository : IRepositories<Drug>
    {
        private static int id;
        public Drug Create(Drug entity)
        {
            id++;
            entity.ID = id;
            DataBaseContext.Drugs.Add(entity);
            return entity;
        }
        public Drug Update(Drug entity)
        {
            var drug= DataBaseContext.Drugs.Find(d => d.ID == entity.ID);
            if (drug != null)
            {
                drug.Name = entity.Name;
                drug.Price = entity.Price;
                drug.drugstore = entity.drugstore;
                drug.Count = entity.Count;
            }
            return drug;
        }

        public void Delete(Drug entity)
        {
            DataBaseContext.Drugs.Remove(entity);
        }

        public List<Drug> GetAll(Predicate<Drug> filter = null)
        {
            if (filter == null)
            {
                return DataBaseContext.Drugs;
            }
            else
            {
                return DataBaseContext.Drugs.FindAll(filter);
            }
        }

        public Drug Get(Predicate<Drug> filter)
        {
            if (filter == null)
            {
                return DataBaseContext.Drugs[0];
            }
            else
            {
                return DataBaseContext.Drugs.Find(filter);
            }
        }

        
    }
}
