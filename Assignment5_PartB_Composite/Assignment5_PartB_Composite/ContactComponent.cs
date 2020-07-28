using System;

namespace Assignment5_PartB_Composite
{
    internal abstract class ContactComponent
    {
        internal virtual void add(ContactComponent cc)
        {
            throw new NotImplementedException();
        }
        internal virtual void listContactDetails()
        {
            throw new NotImplementedException();
        }
    }
}