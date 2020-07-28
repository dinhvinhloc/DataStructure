using System;
using System.Collections.Generic;

namespace CompositeDemo
{
    internal class Menu : MenuComponent
    {
        private string id;
        private string menuName;

        List<MenuComponent> menuComponent = new List<MenuComponent>();


        public Menu(string id, string menuName)
        {
            this.id = id;
            this.menuName = menuName;
        }

        internal override void AddItem(MenuComponent mc)
        {
            menuComponent.Add(mc);
        }

        internal override void Display()
        {
            Console.WriteLine($"ID: {id}; Description: {menuName}");

            foreach (var item in menuComponent)
            {
                item.Display();
            }
        }
    }
}