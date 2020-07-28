using System.Collections.Generic;

namespace Assignment5_PartA_Adapter
{
    internal class MyQueue : IMyQueue
    {
        LinkedList<string> theQueue = new LinkedList<string>();

        public void Enqueue(string t)
        {
            theQueue.AddLast(t);
        }
        public string Dequeue()
        {
            string t;
            t = theQueue.First.Value;
            theQueue.RemoveFirst();
            return t;
        }
        public string Peek()
        {
            return theQueue.First.Value;
        }
        public void PrintAll()
        {
            foreach (string word in theQueue)
            {
                System.Console.WriteLine(word + " ");
            }
        }
    }
}