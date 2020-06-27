using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class mainForm : Form
    {
        StockDB inventory = new StockDB();
        
        BillDB bill = new BillDB();
        public mainForm()
        {

            InitializeComponent();
           
            RefreshData();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (txtCode.Text != "" && txtName.Text != "")
            {
            if (inventory.AddStockItem(GetProductFromScreen()))
                lblInfo.Text = "Product added";
            else lblInfo.Text = "Item existed";
            RefreshData();
            } else lblInfo.Text = "Please fill in both Item Code and Name";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (txtCode.Text != "")
            {
                StockItem temp = inventory.findByCode(txtCode.Text);
                if (temp != null)
                {
                    lblInfo.Text = "Found " + temp.ToString();
                }
                else lblInfo.Text = "Product not found";
            }
            else lblInfo.Text = "Product not found";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (inventory.UpdateStockItem(GetProductFromScreen()))
                lblInfo.Text = "Product updated";
            else lblInfo.Text = "Item not existed";
            RefreshData();
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            int addingQty = 0;
            if (txtQtySold.Text != "")
                addingQty = Convert.ToInt32(txtQtySold.Text);
            if (txtBillName.Text != null)
            {
                StockItem tempStockItem = inventory.findByName(txtBillName.Text);
                if (tempStockItem == null)
                    {
                    lblInfo.Text = "Item is not in inventory, can't add to bill";
                    return;
                    }
                else if (tempStockItem.InStockQty >= addingQty)
                {
                    BillItem addingBillItem = new BillItem();
                    addingBillItem.Code = tempStockItem.Code;
                    addingBillItem.Name = tempStockItem.Name;
                    addingBillItem.setPrice(tempStockItem.UnitPrice);
                    addingBillItem.setQuantitySold(addingQty);
                    bill.AddBillItem(addingBillItem);
                    RefreshData();
                } else lblInfo.Text = "Can't add more than stock quantity";
            }
            else lblInfo.Text = "Item is not in inventory, can't add to bill";
        }

        public StockItem GetProductFromScreen()
        {
            StockItem item = new StockItem();
            item.Code = txtCode.Text;
            item.Name = txtName.Text;
            if (!string.IsNullOrEmpty(txtPrice.Text))
            {
                item.UnitPrice = Convert.ToDouble(txtPrice.Text);
            }
            else item.UnitPrice = 0;
            if (!string.IsNullOrEmpty(txtQty.Text))
            {
                item.InStockQty = Convert.ToInt32(txtQty.Text);
            }
            else item.UnitPrice = 0;

            return item;
        }


        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtQtySold_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void RefreshData()
        {
            inventoryGridView.DataSource = inventory.GetStockItems();
            inventoryGridView.Refresh();
            billGridView.DataSource = bill.GetBillItems();
            billGridView.Refresh();

            txtInvoiceTotal.Text = Convert.ToString(bill.InVoiceTotal);
        }

        private void btnInventoryGridDisplay_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnBillGridDisplay_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btbClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtCode.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtQtySold.Text = "";
            txtBillName.Text = "";
        }
    }
}
