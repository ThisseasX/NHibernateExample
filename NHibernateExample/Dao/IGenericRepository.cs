using System.Collections.Generic;
using NHibernateExample.Entities.Base;

namespace NHibernateExample.Dao
{
    public interface IGenericRepository<T> where T : Entity
    {
        IList<int> Ids();
        IList<T> List();
        T Get(int id);
        T Save(T t);
        T Edit(T t);
        T Delete(int id);
    }
}
