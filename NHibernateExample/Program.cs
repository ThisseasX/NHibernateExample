using NHibernateExample.Services;
using NHibernateExample.Services.Impl;
using NHibernateExample.Utils;

namespace NHibernateExample
{
    public partial class Program
    {
        private static IPersonService _personService;

        static Program()
        {
            _personService = new PersonService();
        }

        static void Main(string[] args)
        {
            // Demo Cases:
            // _personService.PrintPersonIds();
            // _personService.PrintAllPeople();
            // _personService.PrintPersonById(5);
            // _personService.SavePerson(PersonUtils.CreateValidPerson());
            // _personService.SavePerson(PersonUtils.CreateInvalidPerson());
            // _personService.EditPerson(PersonUtils.CreatePersonForEdit());
            // _personService.EditPerson(PersonUtils.CreatePersonForEdit(3));
            // _personService.DeletePerson(4);

            // Note: You can call any of the first 3 Methods
            // multiple times consecutively, to test if the
            // caching works properly (only 1 of the same query
            // will be fired)
        }
    }
}
