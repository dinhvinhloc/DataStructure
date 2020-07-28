using System.Collections.Generic;

namespace Assignment5_PartA_Adapter
{
    internal class MyStack : IMyStack
    {
        LinkedList<string> theStack = new LinkedList<string>();
        public void Push(string t)
        {
            theStack.AddFirst(t);
        }

        public string Pop()
        {
            string t;
            t = theStack.First.Value;
            theStack.RemoveFirst();
            return t;
        }

        public string Peek()
        {
            return theStack.First.Value;
        }

        public void PrintAll()
        {
            foreach(string word in theStack)
            {
                System.Console.WriteLine(word + " ");
            }
        }

    }
}