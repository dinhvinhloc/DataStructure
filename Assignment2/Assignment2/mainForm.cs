using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class mainForm : Form
    {
        ProductList listOfProduct = new ProductList();
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        public Product GetProductFromScreen()
        {
            Product product = new Product();
            product.ProductCode = txtID.Text;
            product.ProductName = txtName.Text;
            if (!string.IsNullOrEmpty(txtPrice.Text))
            {
                product.Price = Convert.ToDouble(txtPrice.Text);
            }
            else product.Price = 0;
            return product;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listOfProduct.Add(GetProductFromScreen()))
                lblInfo.Text = "Product added";
            else lblInfo.Text = "Product updated";
            RefreshData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listOfProduct.Remove(GetProductFromScreen()))
                lblInfo.Text = "Product Removed";
            else lblInfo.Text = "Product Not Found";

            RefreshData();
        }

        public void RefreshData()
        {
            dataGridView.DataSource = listOfProduct.GetProducts();
            dataGridView.Refresh();
            lblProductCount.Text = Convert.ToString(listOfProduct.Products.Count);
            lblAvgPrice.Text = Convert.ToString(listOfProduct.AvgPrice);
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
    }
}
