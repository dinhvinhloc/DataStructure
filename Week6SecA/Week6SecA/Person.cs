using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6SecA
{
    public class Person : IEquatable<Person>, IComparable<Person>
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public int CompareTo(Person other)
        {
            if (Age == other.Age)
                return 0;
            else if (Age > other.Age)
                return 1;
            else
                return -1;
        }
        
        public bool Equals(Person  other)
        {
            if (Name == other.Name)
            {
                return true;
            }
            else return false;
        }

        public override int GetHashCode()
        {
            return Age.GetHashCode();
        }
    }
}
