namespace NHibernateExample.Entities.Base
{
    public class Entity
    {
        // All properties must be virtual
        // for the Mappings to work
        public virtual int Id { get; set; }
    }
}
