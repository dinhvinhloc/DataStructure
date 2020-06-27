using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class StockItem : Item
    {
        private int inStockQty;

        public int InStockQty { get => inStockQty; set => inStockQty = value; }

        public StockItem()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is StockItem item &&
                   Code == item.Code &&
                   Name == item.Name;
        }

        public override int GetHashCode()
        {
            int hashCode = 1338805368;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Code);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }

        public override string ToString()
        {
            return "[Code: " + Code +"; "+
                "Name: " + Name + "; " +
                "Price: " + UnitPrice + "; " +
                "In Stock: " + InStockQty + "]";
        }
    }
}
