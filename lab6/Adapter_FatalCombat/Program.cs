using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_FatalCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            Shooter shooter1 = new Shooter();
            ObjAdShooter shooter2 = new ObjAdShooter();

            Console.WriteLine("Shooter 1 health: " + shooter1.getHealth());
            shooter1.incHealth();
            shooter1.incHealth();
            Console.WriteLine("Shooter 1 health: " + shooter1.getHealth());

            Console.WriteLine("Shooter 2 health: " + shooter2.getHealth());
            shooter2.incHealth();
            shooter2.incHealth();
            shooter2.incHealth();
            Console.WriteLine("Shooter 2 health: " + shooter2.getHealth());

            Console.ReadLine();
        }
    }
}
