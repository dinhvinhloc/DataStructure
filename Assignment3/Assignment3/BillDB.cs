using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class BillDB
    {
        private HashSet<BillItem> billList = new HashSet<BillItem>();

        private double inVoiceTotal;

        public double InVoiceTotal { get => inVoiceTotal; set => inVoiceTotal = value; }

        public bool AddBillItem(BillItem billItem)
        {
            if (billList.Contains(billItem))
            {
                billList.Remove(billItem);
                billList.Add(billItem);
                SetInvoiceTotal();
                return true;
            }
            else
            {
                billList.Add(billItem);
                SetInvoiceTotal();
                return false;
            }


        }

        public bool RemoveBillItem(BillItem billItem)
        {
            if (billList.Remove(billItem))
            {
                SetInvoiceTotal();
                return true;
            }
            else return false;
        }

        public void SetInvoiceTotal()
        {
            double total = 0;
            BillItem[] tempArray = billList.ToArray<BillItem>();
            foreach (BillItem item in tempArray)
            {
                total += item.SubTotal;
            }
            InVoiceTotal = total;
        }






        public BillItem[] GetBillItems()
        {
            return billList.ToArray<BillItem>();        }
    }
}
