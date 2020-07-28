namespace Observer
{
    internal interface Subject
    {
        void Register(Observer o);
        void Remove(Observer o);
        void Notify();
        void SetTemp(int v);
    }
}