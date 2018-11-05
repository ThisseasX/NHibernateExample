using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions.Helpers;
using NHibernate;
using NHibernateExample.Entities.Base;

namespace NHibernateExample.Utils
{
    public class SessionFactoryUtils
    {
        public static ISessionFactory GetSessionFactory()
        {
            return Fluently.Configure()

                .Database(MySQLConfiguration.Standard
                    .ConnectionString(x => x.FromAppSetting("ConnectionString"))
                    .ShowSql()) // Show SQL Queries, to test if the caching works

                .Cache(x => x
                    .UseQueryCache()
                    .UseSecondLevelCache()
                    .ProviderClass<NHibernate.Cache.HashtableCacheProvider>())

                .Mappings(m => m.FluentMappings
                    .AddFromAssemblyOf<Entity>() // Add all Mappings for descendants of Entity

                    // Conventions to specify that all Properties (and Primary Key)
                    // look like "TABLE_PROPERTY"
                    // e.g. "PERSON_NAME" / "DOG_ID"
                    .Conventions.Add(
                        ConventionBuilder.Property.Always(c => c.Column(c.EntityType.Name.ToUpper() + "_" + c.Property.Name.ToUpper())),
                        PrimaryKey.Name.Is(c => c.EntityType.Name.ToUpper() + "_ID")))

                .BuildSessionFactory();
        }
    }
}
