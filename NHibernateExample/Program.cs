using Autofac;
using NHibernateExample.Services;
using NHibernateExample.Utils;

namespace NHibernateExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var container = IoCBuilder.Build();
            using (var scope = container.BeginLifetimeScope())
            {
                var _personService = scope.Resolve<IPersonService>();

                // Demo Cases:

                // _personService.PrintPersonIds();
                // _personService.PrintAllPeople();
                // _personService.PrintAllCities();
                // _personService.PrintPersonById(5);
                // _personService.SavePerson(PersonUtils.CreateValidPerson());
                // _personService.SavePerson(PersonUtils.CreateInvalidPerson());
                // _personService.EditPerson(PersonUtils.CreatePersonForEdit());
                // _personService.EditPerson(PersonUtils.CreatePersonForEdit(3));
                // _personService.DeletePerson(4);

                // Note: You can call any of the first 4 Methods
                // multiple times consecutively, to test if the
                // caching works properly (only 1 of the same query
                // will be fired)
            }
        }
    }
}
