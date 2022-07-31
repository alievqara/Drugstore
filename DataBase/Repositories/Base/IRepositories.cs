using Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositories.Base
{
    public interface IRepositories<T> where T : IEntity
    {
        T Create(T entity);

        T Get(Predicate<T> filter);
    }
}
