using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Business
{
    public class Student : IEquatable<Student>
    {
        private string studentID;        
        private string studentName;
        private double obtainedScore;
        private double maxScore;
        private List<Assignment> assignmentList;

        public Student(string studentID, string studentName)
        {
            this.StudentID = studentID;
            this.StudentName = studentName;
            this.ObtainedScore = 0;
            this.MaxScore = 0;
            this.assignmentList = new List<Assignment>();
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public double ObtainedScore { get => obtainedScore; set => obtainedScore = value; }
        public double MaxScore { get => maxScore; set => maxScore = value; }

        public bool AddAssignment(Assignment assignment)
        {
            if (assignmentList.Contains(assignment))
            {
                assignmentList.Remove(assignment);
                assignmentList.Add(assignment);
                SetMaxScored();
                SetObtainedScored();
                return false;
            }
            else
            {
                assignmentList.Add(assignment);
                SetMaxScored();
                SetObtainedScored();
                return true;
            }
        }

        public bool RemoveAssignment(Assignment assignment)
        {
            if (assignmentList.Contains(assignment))
            {
                assignmentList.Remove(assignment);
                SetMaxScored();
                SetObtainedScored();
                return true;
            }
            else return false;
        }

        
        public void SetMaxScored()
        {
            this.MaxScore = assignmentList.Count * Assignment.maxScore;
        }

        public void SetObtainedScored()
        {
            double score = 0;
            for (int i = 0; i < assignmentList.Count; i++)
            {
                score = score + assignmentList.ElementAt(i).Score;
            }
            this.obtainedScore = score;
        }

        public bool Equals(Student other)
        {
            if (other == null) return false;
            return (studentID == other.studentID);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Student objAsStudent = obj as Student;
            if (objAsStudent == null) return false;
            else return Equals(objAsStudent);
        }

        public List<Assignment> GetAssignments()
        {
            return assignmentList;
        }

    }
}
