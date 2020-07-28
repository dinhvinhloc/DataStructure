using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            TempSubject tempSubject = new TempSubject();
            TempSubject tempSubject2 = new TempSubject();

            Observer tempObserver1 = new TempObserver(tempSubject);
            Observer tempObserver2 = new TempObserver(tempSubject);
            Observer tempObserver3 = new TempObserver(tempSubject2);

            tempSubject.SetTemp(7);
            tempSubject2.SetTemp(47);

            Console.ReadLine();


        }
    }
}
