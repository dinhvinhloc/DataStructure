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
            Console.WriteLine("--------- Original --------");
            Student p1 = new Student("John", "Java","001");
            Console.WriteLine("Original Object");
            Console.WriteLine("Person: {0} - Course Name: {1} - Course ID: {2}", p1.getName(), p1.getCourse().getName(), p1.getCourse().getID());

            Student p2 = p1.Clone();
            Console.WriteLine("Clone Created");
            Console.WriteLine("Person: {0} - Course Name: {1} - Course ID: {2}", p2.getName(), p2.getCourse().getName(), p1.getCourse().getID());

            Student p3 = p1.DeepCopy();
            Console.WriteLine("Deep Clone Created");
            Console.WriteLine("Person: {0} - Course Name: {1} - Course ID: {2} - Course ID: {2}", p3.getName(), p3.getCourse().getName(), p1.getCourse().getID());


            Console.WriteLine("--------- After modified --------");

            p2.Name = "Mary";
            p2.getCourse().setName("C#");
            p2.getCourse().setID("002");

            p3.Name = "Tom";
            p3.getCourse().setName("SQL");
            p3.getCourse().setID("003");

            Console.WriteLine("Original Object");
            Console.WriteLine("Person: {0} - Course Name: {1} - Course ID: {2}", p1.getName(), p1.getCourse().getName(), p1.getCourse().getID());

            Console.WriteLine("Clone Created");
            Console.WriteLine("Person: {0} - Course Name: {1} - Course ID: {2}", p2.getName(), p2.getCourse().getName(), p1.getCourse().getID());

            Console.WriteLine("Deep Clone Created");
            Console.WriteLine("Person: {0} - Course Name: {1} - Course ID: {2}", p3.getName(), p3.getCourse().getName(), p1.getCourse().getID());

            //Console.WriteLine(p1.Equals(p2));
            //Console.WriteLine(p1.getCourse().Equals(p2.getCourse()));

            //Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p2.GetHashCode());

            //Console.WriteLine(p1.getCourse().GetHashCode());
            //Console.WriteLine(p2.getCourse().GetHashCode());

            Console.ReadLine();
        }
    }
}
