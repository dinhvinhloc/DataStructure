using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week1SecA.Business;
using Week1SecA.Data;

namespace Week1SecA
{
	public partial class frmMain : Form
	{
		private Client client = null;
		//private ClientDB clientlist = new ClientDB();
		private ClientDBList clientlist = new ClientDBList();

		public frmMain()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
			client = new Client();
			client.FirstName = txtFirstName.Text;
			client.setLastName(txtLastName.Text);
			if (clientlist.AddClient(client))
            {
				MessageBox.Show("Client Added Successfully", "Add Client", MessageBoxButtons.OK);
            } else
            {
				MessageBox.Show("Failed to add Client", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
			client = new Client();
			client.FirstName = txtFirstName.Text;
			client.setLastName(txtLastName.Text);
			if (clientlist.RemoveCLient(client))
			{
				MessageBox.Show("Client Removed Successfully", "Remove Client", MessageBoxButtons.OK);
			}
			else
			{
				MessageBox.Show("Failed to remove Client", "Remove Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
        private void btnDisplay_Click(object sender, EventArgs e)
        {
			Client[] clients = clientlist.GetClient().ToArray<Client>();
			if (client != null)
            {
				dataGridView1.DataSource = clients;
				dataGridView1.Refresh();
            }
        }

    }
}
