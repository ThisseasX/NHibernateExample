using Autofac;
using NHibernate;
using NHibernateExample.Dao;
using NHibernateExample.Dao.Impl;
using NHibernateExample.Services;
using NHibernateExample.Services.Impl;

namespace NHibernateExample.Utils
{
    public class IoCBuilder
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<PersonService>().As<IPersonService>();
            builder.RegisterType<PersonRepository>().As<IPersonRepository>();
            builder.Register(x => SessionFactoryUtils.GetSessionFactory())
                .As<ISessionFactory>()
                .SingleInstance();

            return builder.Build();
        }
    }
}
