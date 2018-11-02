using System;
using System.Collections.Generic;
using NHibernateExample.Dao;
using NHibernateExample.Dao.Impl;
using NHibernateExample.Entities;
using NHibernateExample.Utils;

namespace NHibernateExample.Services.Impl
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _personDao;

        public PersonService()
        {
            _personDao = new PersonRepository();
        }

        public void PrintPersonIds()
        {
            IList<int> ids = _personDao.Ids();

            foreach (int id in ids)
            {
                Console.WriteLine(id);
            }
        }

        public void PrintAllPeople()
        {
            IList<Person> personList = _personDao.List();

            foreach (Person p in personList)
            {
                PersonUtils.PrintPerson(p);
            }
        }

        public void PrintPersonById(int id)
        {
            Person person = _personDao.Get(id);

            PersonUtils.PrintPerson(person);
        }

        public void SavePerson(Person p)
        {
            Person saved = _personDao.Save(p);

            PersonUtils.PrintResult(0, p, saved, "saved");
        }

        public void EditPerson(Person p)
        {
            int id = p != null
                 ? p.Id
                 : 0;

            Person edited = _personDao.Edit(p);

            PersonUtils.PrintResult(id, p, edited, "edited");
        }

        public void DeletePerson(int id)
        {
            Person deleted = _personDao.Delete(id);

            PersonUtils.PrintResult(id, null, deleted, "deleted");
        }
    }
}
