using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6SecA
{
    public partial class mainForm : Form
    {
        PersonDB s1 = new PersonDB();
        PersonDB s2 = new PersonDB();



        public mainForm()
        {
            InitializeComponent();
        }

        private void btnAddS1_Click(object sender, EventArgs e)
        {
            if (s1.AddPerson(GetPerson()))
            {
                MessageBox.Show("Person is added to the set", "Add Person");
            } else
                MessageBox.Show("Failed to add person to the set", "Add Person");

        }

        private void btnDisplayS1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = s1.GetAllPerson().ToArray<Person>();
            dataGridView1.Refresh();
        }

        private void btnAddS2_Click(object sender, EventArgs e)
        {
            if (s2.AddPerson(GetPerson()))
            {
                MessageBox.Show("Person is added to the set", "Add Person");
            }
            else
                MessageBox.Show("Failed to add person to the set", "Add Person");
        }

        private void btnDisplayS2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = s2.GetAllPerson().ToArray<Person>();
            dataGridView1.Refresh();
        }

        private void btnCommon_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = s1.Common(s2.GetAllPerson()).ToArray<Person>();
            dataGridView1.Refresh();

        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = s1.Merge(s2.GetAllPerson()).ToArray<Person>();
            dataGridView1.Refresh();

        }

        private void btnRemoveCommon_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = s1.RemoveCommon(s2.GetAllPerson()).ToArray<Person>();
            dataGridView1.Refresh();
        }

        private Person GetPerson()
        {
            Person person = new Person();
            person.Name = txtName.Text;
            person.Age = Convert.ToInt32(txtAge.Text);
            return person;
        }
    }
}
