using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_SecA
{
    public partial class mainForm : Form
    {
        Train train = new Train();
        public mainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = train.GetTrainCoaches();
            dataGridView.Refresh();
        }

        public void RefreshData()
        {
            dataGridView.DataSource = train.GetTrainCoaches();
            dataGridView.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = train.GetTrainCoaches();
            dataGridView.Refresh();
        }

        public TrainCoach GetTrainCoach()
        {
            TrainCoach coach = new TrainCoach();
            coach.CoachID = Convert.ToInt32(txtCoachID.Text);
            coach.LoadCapacity = Convert.ToDouble(txtLoadCapacity.Text);
            coach.CoachType = txtCoachType.Text;
            return coach;
        }

        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            if (train.AddFront(GetTrainCoach()) != null)
                MessageBox.Show("Coach is added at the front of the train", "Add Front", MessageBoxButtons.OK);
            else MessageBox.Show("Failed to add coach at the front of the train", "Add Front", MessageBoxButtons.OK, MessageBoxIcon.Error);
            RefreshData();
        }
            

        private void btnAddLast_Click(object sender, EventArgs e)
        {
            if (train.AddEnd(GetTrainCoach()) != null)
                MessageBox.Show("Coach is added at the end of the train", "Add End", MessageBoxButtons.OK);
            else MessageBox.Show("Failed to add coach at the front of the train", "Add End", MessageBoxButtons.OK, MessageBoxIcon.Error);
            RefreshData();

        }

        private void btnAddBefore_Click(object sender, EventArgs e)
        {
            if (train.InsertBefore(Convert.ToInt32(txtCoachIDTarget.Text), GetTrainCoach()))
                MessageBox.Show("Coach is added before the given Coach ID", "Add Before", MessageBoxButtons.OK);
            else MessageBox.Show("Failed to add coach before the given Coach ID", "Add Before", MessageBoxButtons.OK, MessageBoxIcon.Error);
            RefreshData();

        }

        private void btbAddAfter_Click(object sender, EventArgs e)
        {
            if (train.InsertAfter(Convert.ToInt32(txtCoachIDTarget.Text), GetTrainCoach()))
                MessageBox.Show("Coach is added after the given Coach ID", "Add Before", MessageBoxButtons.OK);
            else MessageBox.Show("Failed to add coach after the given Coach ID", "Add Before", MessageBoxButtons.OK, MessageBoxIcon.Error);
            RefreshData();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (train.RemoveAt(Convert.ToInt32(txtCoachIDTarget.Text), GetTrainCoach()))
                MessageBox.Show("Coach is removed", "Add Before", MessageBoxButtons.OK);
            else MessageBox.Show("Failed to remove coach", "Add Before", MessageBoxButtons.OK, MessageBoxIcon.Error);
            RefreshData();

        }

        private void btnRemoveBefore_Click(object sender, EventArgs e)
        {
            if (train.RemoveBefore(Convert.ToInt32(txtCoachIDTarget.Text), GetTrainCoach()))
                MessageBox.Show("Coach before given coach id is removed", "Add Before", MessageBoxButtons.OK);
            else MessageBox.Show("Failed to remove the coach before the given coach id", "Add Before", MessageBoxButtons.OK, MessageBoxIcon.Error);
            RefreshData();

        }

        private void btnRemoveAfter_Click(object sender, EventArgs e)
        {
            if (train.RemoveAfter(Convert.ToInt32(txtCoachIDTarget.Text), GetTrainCoach()))
                MessageBox.Show("Coach after given coach id is removed", "Add Before", MessageBoxButtons.OK);
            else MessageBox.Show("Failed to remove the coach after the given coach id", "Add Before", MessageBoxButtons.OK, MessageBoxIcon.Error);
            RefreshData();

        }
    }
}
