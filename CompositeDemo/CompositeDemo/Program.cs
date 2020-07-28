using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem mi1 = new MenuItem("CB1","ChickenBriyani",9.0); //Leaf /Individual
            MenuItem mi2 = new MenuItem("CF1", "ChickenFriedRice", 8.0); //Leaf
            MenuItem mi3 = new MenuItem("SD1", "Some Desert", 5.0); //Leaf

            Menu m1 = new Menu("LM", "Lunch Menu");
            
            m1.AddItem(mi1);
            m1.AddItem(mi2);

            Menu mFM = new Menu("FM", "Full Menu");
            mFM.AddItem(m1);
            mFM.AddItem(mi3);

            mFM.Display();

            Console.ReadLine();
        }
    }
}
