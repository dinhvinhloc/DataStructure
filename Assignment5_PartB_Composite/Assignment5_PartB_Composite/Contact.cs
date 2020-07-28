using System;

namespace Assignment5_PartB_Composite
{
    internal class Contact : ContactComponent
    {
        private string fistName;
        private string lastName;
        private string email;
        private string phone;

        public Contact(string first, string last, string email, string phone)
        {
            this.fistName = first;
            this.lastName = last;
            this.email = email;
            this.phone = phone;
        }

        internal override void listContactDetails()
        {
            Console.WriteLine($"{fistName} {lastName} {email} {phone}");
        }
    }
}