using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_PartA_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();
            MyQueue queue = new MyQueue();

            Console.WriteLine("--------- Stack Demonstration ----------");
            Console.WriteLine("Pushing to the stack ...");
            stack.Push("The");
            stack.Push("nice");
            stack.Push("little");
            stack.Push("puppy");
            Console.WriteLine("\n");
            Console.WriteLine("My Stack values: ");
            stack.PrintAll();
            Console.WriteLine("\n");
            Console.WriteLine("Pop a value ...");
            Console.WriteLine(stack.Pop());
            Console.WriteLine("\n");
            Console.WriteLine("My Stack values: ");
            stack.PrintAll();
            Console.WriteLine("\n");

            Console.WriteLine("Peek value ...");
            Console.WriteLine(stack.Peek());
            Console.WriteLine("--------- Queue Demonstration ----------");
            Console.WriteLine("Enqueue to the queue ...");
            queue.Enqueue("The");
            queue.Enqueue("nice");
            queue.Enqueue("little");
            queue.Enqueue("puppy");
            Console.WriteLine("\n");
            Console.WriteLine("My queue values: ");
            queue.PrintAll();
            Console.WriteLine("\n");
            Console.WriteLine("Dequeue value ...");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine("\n");

            Console.WriteLine("My queue values: ");
            queue.PrintAll();
            Console.WriteLine("\n");

            Console.WriteLine("Peek value ...");
            Console.WriteLine(queue.Peek());





            Console.ReadLine();

        }

    }
}
