using System;

namespace CompositeDemo
{
    internal abstract class MenuComponent
    {
        internal virtual void AddItem(MenuComponent mc)
        {
            throw new NotImplementedException();
        }

        internal virtual void Display()
        {
            throw new NotImplementedException();
        }
    }
}