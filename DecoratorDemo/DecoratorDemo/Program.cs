using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage b1 = new Coffee();
            b1 = new Milk(b1);
            b1 = new Milk(b1);
            b1 = new Vanilla(b1);


            Console.WriteLine($"Price: {b1.getPrice()}");
            Console.ReadLine();
        }

        private interface IBeverage
        {
            double getPrice();
        }

        private class Milk : IBeverage
        {
            private IBeverage b1;
            private double price = 0.25;

            public Milk(IBeverage b1)
            {
                this.b1 = b1;
            }

            public double getPrice()
            {
                return b1.getPrice() + price;
            }
        }

        private class Coffee : IBeverage
        {
            private double price = 1.15;
            public double getPrice()
            {
                return price;
            }
        }

        private class Vanilla : IBeverage
        {
            private IBeverage b1;
            private double price = 0.20;

            public Vanilla(IBeverage b1)
            {
                this.b1 = b1;
            }

            public double getPrice()
            {
                return b1.getPrice() + price;
            }
        }
    }


}
