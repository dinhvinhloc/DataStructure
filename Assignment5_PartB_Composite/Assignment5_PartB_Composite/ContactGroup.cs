using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_PartB_Composite
{
    class ContactGroup : ContactComponent
    {
        private string groupName;
        private string description;

        List<ContactComponent> contactComponents = new List<ContactComponent>();

        public ContactGroup (string name, string desc)
        {
            this.groupName = name;
            this.description = desc;
        }

        internal override void add(ContactComponent cc)
        {
            contactComponents.Add(cc);
        }

        internal override void listContactDetails()
        {
            Console.WriteLine($"{groupName} {description}");

            foreach (var item in contactComponents)
            {
                item.listContactDetails();
            }
        }

    }
}
