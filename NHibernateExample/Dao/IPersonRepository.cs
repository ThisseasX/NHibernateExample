using System.Collections.Generic;
using NHibernateExample.Entities;

namespace NHibernateExample.Dao
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        IList<string> ListAllCities();
    }
}
