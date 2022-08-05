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
    public class DruggistRepository : IRepositories<Druggist>
    {
        private static int id;
        public Druggist Create(Druggist entity)
        {
            id++;
            entity.ID = id;
            DataBaseContext.Druggists.Add(entity);
            return entity;
        }
        public Druggist Update(Druggist entity)
        {
            var druggist = DataBaseContext.Druggists.Find(d => d.ID == entity.ID);
            if (druggist != null)
            {
                druggist.Name = entity.Name;
                druggist.Surname = entity.Name;
            }
            return druggist;
        }

        public void Delete(Druggist entity)
        {
            DataBaseContext.Druggists.Remove(entity);
        }

        public List<Druggist> GetAll(Predicate<Druggist> filter = null)
        {
            if (filter == null)
            {
                return DataBaseContext.Druggists;
            }
            else
            {
                return DataBaseContext.Druggists.FindAll(filter);
            }
        }

        public Druggist Get(Predicate<Druggist> filter)
        {
            if (filter == null)
            {
                return DataBaseContext.Druggists[0];
            }
            else
            {
                return DataBaseContext.Druggists.Find(filter);
            }
        }
    }
}
