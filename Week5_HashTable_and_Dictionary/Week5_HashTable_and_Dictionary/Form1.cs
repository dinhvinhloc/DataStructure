using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_HashTable_and_Dictionary
{
    public partial class Form1 : Form
    { 
        CourseDB cDB = new CourseDB();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Course courseFound = cDB.FindCourse(txtCourseCode.Text);
            if (courseFound == null)
            {
                MessageBox.Show(txtCourseCode.Text + " is not in the list.");
            } else
            {
                txtCourseName.Text = courseFound.Title;
                txtCourseCredit.Text = courseFound.Credit.ToString();
            } 

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Code = txtCourseCode.Text;
            course.Title = txtCourseName.Text;
            course.Credit = Convert.ToInt32(txtCourseCredit.Text);
            if (cDB.SaveCourse(course))
            {
                MessageBox.Show("Add course with course code " + txtCourseCode.Text + " successfull");
            } else
                MessageBox.Show("Failed to add course with course code " + txtCourseCode.Text);

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = cDB.GetCourses();
            dataGridView.Refresh();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cDB.DeleteCourse(txtCourseCode.Text))
            {
                MessageBox.Show(txtCourseCode.Text + " is deleted from the list.");
            }
            else
            {
                MessageBox.Show(txtCourseCode.Text + " is not in the list.");
            }
        }
    }
}
