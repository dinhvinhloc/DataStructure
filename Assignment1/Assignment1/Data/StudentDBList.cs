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

        public bool AddStudent(Student student)
        {
            if (studentList.Contains(student))
                return false;
            else
            {
                studentList.Add(student);
                return true;
            }
        }

        public bool RemoveStudent(Student student)
        {
            if (studentList.Contains(student))
            {
                studentList.Remove(student);
                return true;
            }
            else return false;
        }

        public List<Student> GetStudents()
        {
            return studentList;
        }
    }
}
