using NHibernateExample.Entities;
using FluentNHibernate.Mapping;

namespace NHibernateExample.Mappings
{
    class DogMap : ClassMap<Dog>
    {
        public DogMap()
        {
            Id(x => x.Id);

            Map(x => x.Name);
            Map(x => x.Breed);

            // The other end of the ManyToOne relationship
            References(x => x.Owner, "DOG_OWNER_ID").Unique().Nullable();

            Cache.ReadWrite();
        }
    }
}
