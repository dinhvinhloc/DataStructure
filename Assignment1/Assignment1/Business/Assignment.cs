using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Business
{
    public class Assignment : IEquatable<Assignment>
    {
        private string assignmentID;
        private double score;
        public const double maxScore = 100;

        public Assignment(string assignmentID, double score)
        {
            this.assignmentID = assignmentID;
            this.score = score;
        }

        public string AssignmentID { get => assignmentID; set => assignmentID = value; }
        public double Score { get => score; set => score = value; }
               

        public bool Equals(Assignment other)
        {
            if (other == null) return false;
            return assignmentID == other.assignmentID;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Assignment objAsAssignment = obj as Assignment;
            if (objAsAssignment == null) return false;
            else return Equals(objAsAssignment);
        }
    }
}
