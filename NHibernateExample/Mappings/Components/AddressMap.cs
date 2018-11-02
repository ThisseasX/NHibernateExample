using NHibernateExample.Entities.Component;
using FluentNHibernate.Mapping;

namespace NHibernateExample.Mappings.Components
{
    public class AddressMap : ComponentMap<Address>
    {
        // This Mapping is not used. It's only here
        // for demonstration

        // PersonMap is actually using an 
        // inline Mapping of the Address class
        public AddressMap()
        {
            Map(x => x.Street, "PERSON_STREET");
            Map(x => x.City, "PERSON_CITY");
        }
    }
}
