using System.Collections.Generic;
using NHibernateExample.Entities;

namespace NHibernateExample.Dao.Impl
{
    class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public IList<string> ListAllCities()
        {
            return OpenSession()
                .QueryOver<Person>()
                .Where(x => x.Address != null)
                .Select(x => x.Address.City)
                .List<string>();
        }
    }
}
