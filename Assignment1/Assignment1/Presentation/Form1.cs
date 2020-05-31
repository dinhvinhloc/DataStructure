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
        private Student selectedStudent = new Student();
        private StudentDBList studentlist = new StudentDBList();
        public frmMain()
        {
            InitializeComponent();
            ClearLabelMessage();
            labelID.Text = "";
            labelName.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearLabelMessage();
            if (!string.IsNullOrEmpty(txtStudentID.Text) && !string.IsNullOrEmpty(txtStudentName.Text))
            {
            Student student = new Student(txtStudentID.Text, txtStudentName.Text);
                if (studentlist.AddStudent(student))
                {
                    labelMessage.Text = "Student Added Successfully";
                    selectedStudent = student;
                }
                    
                else
                    labelMessage.Text = "Student is already exist";
                dataGridStudent.DataSource = studentlist.GetStudents().ToArray<Student>();
            dataGridStudent.Refresh();
            }
            else MessageBox.Show("Please enter a valid student", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAddAssignment_Click(object sender, EventArgs e)
        {
            ClearLabelMessage();
            if (!string.IsNullOrEmpty(txtAssignmentID.Text) && !string.IsNullOrEmpty(txtAssignmentScore.Text))
            {
                if (Double.Parse(txtAssignmentScore.Text) <= Assignment.maxScore)
                {
                    Assignment assignment = new Assignment(txtAssignmentID.Text, Double.Parse(txtAssignmentScore.Text));
                    if (selectedStudent.AddAssignment(assignment))
                        labelMessage.Text = "Assignment Added Successfully";
                    else
                        labelMessage.Text = "Assignment Modified Successfully";
                    dataGridAssignment.DataSource = selectedStudent.GetAssignments().ToArray<Assignment>();
                    dataGridAssignment.Refresh();
                    dataGridStudent.Refresh();
                }
                else labelMessage.Text = "Score can't be more than " + Assignment.maxScore;
            } 

            else MessageBox.Show("Please enter a valid Assignement", "Add Assignment", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ClearLabelMessage();
            if (!string.IsNullOrEmpty(txtAssignmentID.Text) && !string.IsNullOrEmpty(txtAssignmentScore.Text))
            {
            Assignment assignment = new Assignment(txtAssignmentID.Text, Double.Parse(txtAssignmentScore.Text));
            if (selectedStudent.FindAssignment(assignment))
            labelMessage.Text = "Assignment Found";
            else labelMessage.Text = "Assignment Not Found";                
            }

            else labelMessage.Text = "Assignment Not Found";
        }
        private void btnAssignmentDelete_Click(object sender, EventArgs e)
        {
            ClearLabelMessage();
            if (!string.IsNullOrEmpty(txtAssignmentID.Text) && !string.IsNullOrEmpty(txtAssignmentScore.Text))
            {
                Assignment assignment = new Assignment(txtAssignmentID.Text, Double.Parse(txtAssignmentScore.Text));
                if (selectedStudent.RemoveAssignment(assignment))
                    labelMessage.Text = "Assignment Remove Successfully";
                else
                    labelMessage.Text = "Student " + selectedStudent.StudentName + " does not have this assignment";
                dataGridAssignment.DataSource = selectedStudent.GetAssignments().ToArray<Assignment>();
                dataGridAssignment.Refresh();
                dataGridStudent.Refresh();
            }
            else labelMessage.Text = "You can't delete an empty assignment";
        }

        private void dataGridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearLabelMessage();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridStudent.CurrentRow.Selected = true;
                string id = dataGridStudent.Rows[e.RowIndex].Cells["StudentID"].FormattedValue.ToString();
                string name = dataGridStudent.Rows[e.RowIndex].Cells["StudentName"].FormattedValue.ToString();

                selectedStudent = studentlist.StudentList.Find(x => x.StudentID == id);
                labelID.Text = selectedStudent.StudentID;
                labelName.Text = selectedStudent.StudentName;
                txtStudentID.Text = selectedStudent.StudentID;
                txtStudentName.Text = selectedStudent.StudentName;
                dataGridAssignment.DataSource = selectedStudent.GetAssignments().ToArray<Assignment>();
                dataGridAssignment.Refresh();
            }
        }
        private void dataGridAssignment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearLabelMessage();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridAssignment.CurrentRow.Selected = true;
                txtAssignmentID.Text = dataGridAssignment.Rows[e.RowIndex].Cells["assignmentID"].FormattedValue.ToString(); ;
                txtAssignmentScore.Text = dataGridAssignment.Rows[e.RowIndex].Cells["score"].FormattedValue.ToString();
            }
        }


        private void txtAssignmentScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClearLabelMessage();
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

        private void ClearLabelMessage()
        {
            labelMessage.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
        private void txtAssignmentScore_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
