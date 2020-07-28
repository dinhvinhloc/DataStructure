using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Labs aLab = Labs.GetLabs(); ;
            List<String> list = aLab.GetLabsList();
            list.Add("New Lab");
            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(list.ElementAt(i));
            }
                       
            Console.ReadLine();
        }
    }
}
