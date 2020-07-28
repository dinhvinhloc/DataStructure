using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree t1 = new Tree("mango");
            Tree t2 = new Tree("mapple");
            Tree t3 = new Tree("mapple");
            Tree t4 = new Tree("oak");
            Tree t5 = new Tree("oak");

            Console.WriteLine("Tree 1 Hash Code: "+t1.GetHashCode());
            Console.WriteLine("Tree 2 Hash Code: " + t2.GetHashCode());
            Console.WriteLine("Tree 3 Hash Code: " + t3.GetHashCode());
            Console.WriteLine("Tree 4 Hash Code: " + t4.GetHashCode());
            Console.WriteLine("Tree 5 Hash Code: " + t5.GetHashCode());

            Console.WriteLine("Tree 1 Properties: " + t1.ListTreeModelProperties());
            Console.WriteLine("Tree 2 Properties: " + t2.ListTreeModelProperties());
            Console.WriteLine("Tree 3 Properties: " + t3.ListTreeModelProperties());
            Console.WriteLine("Tree 4 Properties: " + t4.ListTreeModelProperties());
            Console.WriteLine("Tree 5 Properties: " + t5.ListTreeModelProperties());

            Console.ReadLine();

        }
    }
}
