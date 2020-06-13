using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Product
    {
        private string productCode;
        private string productName;
        private double price;

        public string ProductCode { get => productCode; set => productCode = value; }
        public string ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }

        public bool Equals (Product other)
        {
            return this.ProductName == other.ProductName;
        }

        public override bool Equals(object obj)
        {
            Product tProduct = obj as Product;
            return this.Equals(tProduct);
        }
    }
}
