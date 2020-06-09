using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_SecA
{
    public class TrainCoach
    {
        public int CoachID { get; set; }
        public double LoadCapacity { get; set;}
        public string CoachType { get; set; }

        public bool Equals (TrainCoach other)
        {
            return this.CoachID == other.CoachID;
        }

        public override bool Equals(object obj)
        {
            TrainCoach tCoach = obj as TrainCoach;
            return this.Equals(tCoach);
        }

    }
}
