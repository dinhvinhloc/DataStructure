namespace Assignment5_PartA_Adapter
{
    internal interface IMyQueue
    {
        void Enqueue(string t);
        string Dequeue();
        string Peek();
    }
}