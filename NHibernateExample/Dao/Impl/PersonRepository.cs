using System.Collections.Generic;
using NHibernate;
using NHibernateExample.Entities;

namespace NHibernateExample.Dao.Impl
{
    class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(ISessionFactory sessionFactory) : base(sessionFactory)
        {
        }

        public IList<string> ListAllCities()
        {
            return OpenSession()
                .QueryOver<Person>()
                .Where(x => x.Address != null)
                .Select(x => x.Address.City)
                .Cacheable()
                .List<string>();
        }
    }
}
