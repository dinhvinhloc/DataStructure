using System.Collections.Generic;

namespace Observer
{
    internal class TempSubject2 : Subject
    {
        //List<Temp> list new List<Temp>;

        int temp = 0;

        List<Observer> observers = new List<Observer>();
        public void Notify()
        {
            foreach (var item in observers)
            {
                item.update(temp);
            }
        }

        public void Register(Observer o)
        {
            observers.Add(o);
        }

        public void Remove(Observer o)
        {
            observers.Remove(o); ;
        }

        public void SetTemp(int temp)
        {
            this.temp = temp;
            Notify();
        }
    }
}
    
