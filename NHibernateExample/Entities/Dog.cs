using NHibernateExample.Entities.Base;

namespace NHibernateExample.Entities
{
    public class Dog : Entity
    {
        public virtual string Name { get; set; }
        public virtual string Breed { get; set; }
        public virtual Person Owner { get; set; }
    }
}
