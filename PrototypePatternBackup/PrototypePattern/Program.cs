using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John", "Civic");
            Console.WriteLine("Original Object");
            Console.WriteLine("Person: {0} - Car: {1}", p1.getName(), p1.getCar().getName());

            Person p2 = p1.DeepCopy();
            Console.WriteLine("Clone Created");
            Console.WriteLine("Person: {0} - Car: {1}", p2.getName(), p2.getCar().getName());

            p2.Name = "Paul";
            p2.getCar().setName("Camry");

            Console.WriteLine("Original Object");
            Console.WriteLine("Person: {0} - Car: {1}", p1.getName(), p1.getCar().getName());

            Console.WriteLine("Clone Created");
            Console.WriteLine("Person: {0} - Car: {1}", p2.getName(), p2.getCar().getName());

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.getCar().Equals(p2.getCar()));

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());

            Console.WriteLine(p1.getCar().GetHashCode());
            Console.WriteLine(p2.getCar().GetHashCode());

            Console.ReadLine();
        }
    }
}
