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
        private double totalMaxScore;
        private List<Assignment> assignmentList;
        public Student()
                {
                }
        public Student(string studentID, string studentName)
        {
            this.StudentID = studentID;
            this.StudentName = studentName;
            this.ObtainedScore = 0;
            this.TotalMaxScore = 0;
            this.AssignmentList = new List<Assignment>();
        }

        

        public string StudentID { get => studentID; set => studentID = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public double ObtainedScore { get => obtainedScore; set => obtainedScore = value; }
        public double TotalMaxScore { get => totalMaxScore; set => totalMaxScore = value; }
        public List<Assignment> AssignmentList { get => assignmentList; set => assignmentList = value; }

        public bool AddAssignment(Assignment assignment)
        {
            if (AssignmentList.Contains(assignment))
            {

                Assignment tempAssignment = AssignmentList.Find(x => x.Equals(assignment));
                tempAssignment.Score = assignment.Score;
                SetMaxScored();
                SetObtainedScored();
                return false;
            }
            else
            {
                AssignmentList.Add(assignment);
                SetMaxScored();
                SetObtainedScored();
                return true;
            }
        }

        public bool FindAssignment(Assignment assignment)
        {
            if (AssignmentList.Contains(assignment))
                return true;
            else
                return false;            
        }

        public bool RemoveAssignment(Assignment assignment)
        {
            if (AssignmentList.Contains(assignment))
            {
                AssignmentList.Remove(assignment);
                SetMaxScored();
                SetObtainedScored();
                return true;
            }
            else return false;
        }

        
        public void SetMaxScored()
        {
            this.TotalMaxScore = AssignmentList.Count * Assignment.maxScore;
        }

        public void SetObtainedScored()
        {
            double score = 0;
            for (int i = 0; i < AssignmentList.Count; i++)
            {
                score = score + AssignmentList.ElementAt(i).Score;
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
            return AssignmentList;
        }

    }
}
