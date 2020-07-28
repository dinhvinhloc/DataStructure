namespace Observer
{
    internal class TempObserver : Observer
    {
        private Subject tempSubject;
        private int temp;

        public TempObserver(Subject tempSubject)
        {
            this.tempSubject = tempSubject;
            tempSubject.Register(this);
        }

        public void update(int temp)
        {
            this.temp = temp;
            System.Console.WriteLine("Observer: " + this.GetHashCode() + " was updated to " + temp);
        }
    }
}