namespace Assignment5_PartA_Adapter
{
    internal interface IMyStack
    {
        void Push(string t);
        string Pop();
        string Peek();

        void PrintAll();
    }
}