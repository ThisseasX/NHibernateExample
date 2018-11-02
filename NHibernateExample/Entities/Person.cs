using System.Collections.Generic;
using NHibernateExample.Entities.Base;
using NHibernateExample.Entities.Component;

namespace NHibernateExample.Entities
{
    public class Person : Entity
    {
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual Address Address { get; set; }
        public virtual IList<Dog> Dogs { get; set; }
    }
}
