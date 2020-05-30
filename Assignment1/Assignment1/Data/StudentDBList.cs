using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Business;

namespace Assignment1.Data
{
    public class StudentDBList
    {
        private List<Student> studentList = new List<Student>();

        public List<Student> StudentList { get => studentList; set => studentList = value; }

        public bool AddStudent(Student student)
        {
            if (StudentList.Contains(student))
                return false;
            else
            {
                StudentList.Add(student);
                return true;
            }
        }

        public bool RemoveStudent(Student student)
        {
            if (StudentList.Contains(student))
            {
                StudentList.Remove(student);
                return true;
            }
            else return false;
        }

        public List<Student> GetStudents()
        {
            return StudentList;
        }
    }
}
