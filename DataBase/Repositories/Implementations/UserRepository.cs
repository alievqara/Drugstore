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
    public class UserRepository : IRepositories<User>
    {
        public User Create(User entity)
        {
            throw new NotImplementedException();
        }

        public User Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User Get(Predicate<User> filter)
        {
            if (filter == null)
            {
                return DataBaseContext.Users[0];
            }
            else
            {
                return DataBaseContext.Users.Find(filter);
            }
        }

        public List<User> GetAll(Predicate<User> filter = null)
        {
            throw new NotImplementedException();
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }

        void IRepositories<User>.Delete(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
