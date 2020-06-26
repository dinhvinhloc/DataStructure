using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6SecA
{
    public class PersonDB
    {
        private HashSet<Person> persons = new HashSet<Person>();
        public bool AddPerson(Person person)
        {
                return persons.Add(person);
        }

        public HashSet<Person> GetAllPerson()
        {
            return persons;
        }

        public HashSet<Person> Common(HashSet<Person> anotherSet)
        {
            HashSet<Person> temp = new HashSet<Person>(persons);
            temp.IntersectWith(anotherSet);
            return temp;
        }

        public HashSet<Person> Merge(HashSet<Person> anotherSet)
        {
            HashSet<Person> temp = new HashSet<Person>(persons);
            temp.UnionWith(anotherSet);
            return temp;
        }
        public HashSet<Person> RemoveCommon(HashSet<Person> anotherSet)
        {
            HashSet<Person> temp = new HashSet<Person>(persons);
            temp.SymmetricExceptWith(anotherSet);
            return temp;
        }
    }


}
