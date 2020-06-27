using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class BillItem : Item, IEquatable<BillItem>, IComparable<BillItem>
    {
        private int quantitySold;
        private double subTotal;

        public int QuantitySold { get => quantitySold; set => quantitySold = value; }
        public double SubTotal { get => subTotal; set => subTotal = value; }


        public int CompareTo(BillItem other)
        {
            if (Code == other.Code)
                return 0;
            else if (Code != other.Code)
                return 1;
            else
                return -1;
        }

        public bool Equals(BillItem other)
        {
            if (Name == other.Name | Code == other.Code)
            {
                return true;
            }
            else return false;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void setQuantitySold(int qty)
        {
            this.QuantitySold = qty;
            this.SubTotal = qty * UnitPrice;
        }

        public void setPrice(double price)
        {
            this.UnitPrice = price;
            this.SubTotal = price * QuantitySold;
        }
    }
    
}
