using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private StudentDBList studentList = new StudentDBList();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student(txtStudentID.Text, txtStudentName.Text);
            if (studentList.AddStudent(student))
            MessageBox.Show("Student Added Successfully", "Add Student", MessageBoxButtons.OK);
            else MessageBox.Show("Student is already exist", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

            dataGridStudent.DataSource = studentList.GetStudents().ToArray<Student>();
            dataGridStudent.Refresh();
        }
    }
}
