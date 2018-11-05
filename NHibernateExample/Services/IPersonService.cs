using NHibernateExample.Entities;

namespace NHibernateExample.Services
{
    public interface IPersonService
    {
        void PrintPersonIds();
        void PrintAllPeople();
        void PrintAllCities();
        void PrintPersonById(int id);
        void SavePerson(Person p);
        void EditPerson(Person p);
        void DeletePerson(int id);
    }
}