using System;

namespace CompositeDemo
{
    internal class MenuItem : MenuComponent
    {
        private string id;
        private string itemName;
        private double price;

        public MenuItem(string v1, string v2, double v3)
        {
            this.id = v1;
            this.itemName = v2;
            this.price = v3;
        }
        internal override void Display()
        {
            Console.WriteLine($"ID: {id}; Description: {itemName}; Price: {price}");


        }
    }
}