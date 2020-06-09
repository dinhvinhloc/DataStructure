using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_SecA
{
    public class Train
    {
        private LinkedList<TrainCoach> coaches = new LinkedList<TrainCoach>();

        public LinkedListNode<TrainCoach> AddFront(TrainCoach coach)
        {
            return coaches.AddFirst(coach);
        }
        public LinkedListNode<TrainCoach> AddEnd(TrainCoach coach)
        {
            return coaches.AddLast(coach);
        }

        public bool InsertAfter(int id, TrainCoach coach)
        {
            TrainCoach tCoach = new TrainCoach();
            tCoach.CoachID = id;
            LinkedListNode<TrainCoach> targetNode = coaches.Find(tCoach);

            if (targetNode != null)
            {
                coaches.AddAfter(targetNode, coach);
                return true;
            }
            return false;

        }
        public bool InsertBefore(int id, TrainCoach coach)
        {
            TrainCoach tCoach = new TrainCoach();
            tCoach.CoachID = id;
            LinkedListNode<TrainCoach> targetNode = coaches.Find(tCoach);

            if (targetNode != null)
            {
                coaches.AddBefore(targetNode, coach);
                return true;
            }
            return false;
        }

        public bool RemoveAt(int id, TrainCoach coach)
        {
            TrainCoach tCoach = new TrainCoach();
            tCoach.CoachID = id;
            LinkedListNode<TrainCoach> targetNode = coaches.Find(tCoach);

            if (targetNode != null)
            {
                coaches.Remove(targetNode);
                return true;
            }
            return false;
        }
        public bool RemoveBefore(int id, TrainCoach coach)
        {
            TrainCoach tCoach = new TrainCoach();
            tCoach.CoachID = id;
            LinkedListNode<TrainCoach> targetNode = coaches.Find(tCoach);

            if (targetNode.Previous != null)
            {
                coaches.Remove(targetNode.Previous);
                return true;
            }
            return false;
        }
        public bool RemoveAfter(int id, TrainCoach coach)
        {
            TrainCoach tCoach = new TrainCoach();
            tCoach.CoachID = id;
            LinkedListNode<TrainCoach> targetNode = coaches.Find(tCoach);

            if (targetNode.Next != null)
            {
                coaches.Remove(targetNode.Next);
                return true;
            }
            return false;
        }

        public TrainCoach[] GetTrainCoaches()
        {
            return coaches.ToArray<TrainCoach>();
        }

    }
}
