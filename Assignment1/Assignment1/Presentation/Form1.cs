using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment1.Business;
using Assignment1.Data;

namespace Assignment1
{
    public partial class frmMain : Form
    {
        private Student selectedStudent;
        private StudentDBList studentlist = new StudentDBList();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student(txtStudentID.Text, txtStudentName.Text);
            if (studentlist.AddStudent(student))
                MessageBox.Show("Student Added Successfully", "Add Student", MessageBoxButtons.OK);
            else MessageBox.Show("Student is already exist", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

            dataGridStudent.DataSource = studentlist.GetStudents().ToArray<Student>();
            dataGridStudent.Refresh();

        }

        private void btnAddAssignment_Click(object sender, EventArgs e)
        {
            Assignment assignment = new Assignment(txtAssignmentID.Text, Double.Parse(txtAssignmentScore.Text));
            if (selectedStudent.AddAssignment(assignment))
                MessageBox.Show("Assignement Added Successfully", "Add Assignment", MessageBoxButtons.OK);
            else MessageBox.Show("Assignment Modified Successfully", "Modify Assignment", MessageBoxButtons.OK);
            dataGridAssignment.DataSource = selectedStudent.GetAssignments().ToArray<Assignment>();
            dataGridAssignment.Refresh();
            dataGridStudent.Refresh();
        }

        private void dataGridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            if (dataGridStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridStudent.CurrentRow.Selected = true;
                string id = dataGridStudent.Rows[e.RowIndex].Cells["StudentID"].FormattedValue.ToString();
                string name = dataGridStudent.Rows[e.RowIndex].Cells["StudentName"].FormattedValue.ToString();
                Student student = new Student(id, name);
                for (int i = 0; i < studentlist.StudentList.Count(); i++)
                {
                    if (studentlist.StudentList.ElementAt(i).Equals(student))
                        selectedStudent = studentlist.StudentList.ElementAt(i);
                }

                labelID.Text = selectedStudent.StudentID;
                labelName.Text = selectedStudent.StudentName;
                dataGridAssignment.DataSource = selectedStudent.GetAssignments().ToArray<Assignment>();
                dataGridAssignment.Refresh();
            }
        }

        private void txtAssignmentScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAssignmentScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
