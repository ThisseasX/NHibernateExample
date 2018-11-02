using System;
using System.Linq;
using System.Text;
using NHibernateExample.Entities;

namespace NHibernateExample.Utils
{
    public class PersonUtils
    {
        public static void PrintPerson(Person p)
        {
            if (p == null) return;

            StringBuilder sb = new StringBuilder(string.Format("{0}, {1}, {2}", p.Id, p.Name, p.Surname));

            if (p.Dogs.Any())
            {
                sb.Append(", " + p.Dogs[0].Name);
                sb.Append(", " + p.Dogs[0].Breed);
            }

            if (p.Address != null)
            {
                if (!string.IsNullOrEmpty(p.Address.Street))
                    sb.Append(", " + p.Address.Street);
                if (!string.IsNullOrEmpty(p.Address.City))
                    sb.Append(", " + p.Address.City);
            }

            Console.WriteLine(sb);
        }

        public static void PrintResult(int id, Person original, Person result, string action)
        {
            bool success = result != null;

            Person toBePrinted = success ? result : original;

            StringBuilder sb = new StringBuilder("Person", 50);

            string withOrAnd = " with ";

            if (id != 0)
            {
                sb.Append(" with ID = " + id);
                withOrAnd = " and ";
            }

            if (toBePrinted != null && !string.IsNullOrEmpty(toBePrinted.Name))
            {
                sb.Append(withOrAnd + "Name = " + toBePrinted.Name);
            }

            if (success)
                sb.Append(" has been " + action + " successfully.");
            else
                sb.Append(" could not be " + action + ".");

            Console.WriteLine(sb);
        }

        public static Person CreateValidPerson()
        {
            int i = new Random().Next(1, 100);

            return new Person
            {
                Name = "SavedPerson" + i,
                Surname = "SavedSurname" + i
            };
        }

        public static Person CreateInvalidPerson()
        {
            // Person's Name cannot be null
            // so this cannot be saved
            return new Person();
        }

        public static Person CreatePersonForEdit(int id = 1)
        {
            int i = new Random().Next(1, 100);

            return new Person
            {
                Id = id,
                Name = "EditedPerson" + i,
                Surname = "EditedSurname" + i
            };
        }
    }
}
