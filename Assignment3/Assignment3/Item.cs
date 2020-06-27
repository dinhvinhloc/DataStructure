using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Item
    {
        private String code;
        private String name;
        private double unitPrice;

        public Item()
        {
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }


    }
}
