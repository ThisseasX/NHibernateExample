using System;
using System.Collections.Generic;
using NHibernate;
using NHibernateExample.Entities.Base;

namespace NHibernateExample.Dao.Impl
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        private ISessionFactory _sessionFactory;

        public GenericRepository(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        protected ISession OpenSession()
        {
            return _sessionFactory.OpenSession();
        }

        public virtual IList<int> Ids()
        {
            return OpenSession()
                .QueryOver<T>()
                .Select(x => x.Id)
                .Cacheable()
                .List<int>();
        }

        public virtual IList<T> List()
        {
            return OpenSession()
                .QueryOver<T>()
                .Cacheable()
                .List();
        }

        public virtual T Get(int id)
        {
            return OpenSession()
                .QueryOver<T>()
                .Where(x => x.Id == id)
                .Cacheable()
                .SingleOrDefault();
        }

        public virtual T Save(T t)
        {
            using (var session = OpenSession())
            using (var tx = session.BeginTransaction())
            {
                try
                {
                    session.Save(t);
                    tx.Commit();
                    return t;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    tx.Rollback();
                    return null;
                }
            }
        }

        public virtual T Edit(T t)
        {
            using (var session = OpenSession())
            using (var tx = session.BeginTransaction())
            {
                try
                {
                    session.Update(t);
                    tx.Commit();
                    return t;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    tx.Rollback();
                    return null;
                }
            }
        }

        public virtual T Delete(int id)
        {
            using (var session = OpenSession())
            using (var tx = session.BeginTransaction())
            {
                try
                {
                    T t = session.Load<T>(id);
                    session.Delete(t);
                    tx.Commit();
                    return t;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    tx.Rollback();
                    return null;
                }
            }
        }
    }
}
