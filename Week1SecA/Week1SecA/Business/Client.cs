using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
        //java: import; VS: using
        //java: package; VS: namespace
namespace Week1SecA.Business
{
    public class Client : IEquatable<Client>
    {
        //Attributes
        private string firstName, lastName, email, phone;

        //Property Firstname
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName { get => lastName; set => lastName = value; }

        public void setLastName (string lastName)
        {
            this.lastName = lastName;
        }

        public string getLastName ()
        {
            return this.lastName;
        }

        public bool Equals(Client other)
        {
            if (other == null) return false;
            return ((lastName == other.lastName) && (firstName == other.firstName));
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Client objAsClient = obj as Client;
            if (objAsClient == null) return false;
            else return Equals(objAsClient);
        }
    }
}
