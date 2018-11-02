using NHibernateExample.Entities;
using FluentNHibernate.Mapping;

namespace NHibernateExample.Mappings
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Id(x => x.Id);

            Map(x => x.Name).Not.Nullable();
            Map(x => x.Surname);

            // Map the Street and City fields of Person
            // to an Address object
            Component(x => x.Address, m =>
            {
                m.Map(x => x.Street, "PERSON_STREET");
                m.Map(x => x.City, "PERSON_CITY");
            });

            // Always Fetch Person's Dogs
            // and cache them
            HasMany(x => x.Dogs).Fetch.Join().Cache.ReadWrite();

            Cache.ReadWrite();
        }
    }
}
