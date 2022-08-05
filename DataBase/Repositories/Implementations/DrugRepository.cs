using Core.Entities;
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
        public Drug Create(Drug entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Drug entity)
        {
            throw new NotImplementedException();
        }

        public Drug Get(Predicate<Drug> filter)
        {
            throw new NotImplementedException();
        }

        public List<Drug> GetAll(Predicate<Drug> filter = null)
        {
            throw new NotImplementedException();
        }

        public Drug Update(Drug entity)
        {
            throw new NotImplementedException();
        }
    }
}
