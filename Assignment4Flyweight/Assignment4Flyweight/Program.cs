using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Flyweight
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();

            List<Spacecraft> spaceHanger = new List<Spacecraft>();

            for (int i = 0; i < 10; i++)
            {
                Spacecraft spacecraft;
                int dice = rand.Next(1, 4);
                switch (dice)
                {
                    case 1:
                        spacecraft = new Spacecraft("NukeMayhem");
                        spacecraft.CraftID = rand.Next(1000);
                        spacecraft.Coordinate.X = rand.Next(1000);
                        spacecraft.Coordinate.Y = rand.Next(1000);
                        spaceHanger.Add(spacecraft);
                        break;
                    case 2:
                        spacecraft = new Spacecraft("CoreDriller");
                        spacecraft.CraftID = rand.Next(1000);
                        spacecraft.Coordinate.X = rand.Next(1000);
                        spacecraft.Coordinate.Y = rand.Next(1000);
                        spaceHanger.Add(spacecraft);
                        break;
                    case 3:
                        spacecraft = new Spacecraft("SwiftMaple");
                        spacecraft.CraftID = rand.Next(1000);
                        spacecraft.Coordinate.X = rand.Next(1000);
                        spacecraft.Coordinate.Y = rand.Next(1000);
                        spaceHanger.Add(spacecraft);
                        break;
                }
            }

            void launch()
            {
                for (int i = 0; i < spaceHanger.Count; i++)
                {
                    Console.WriteLine(" Spacecraft: " + i + spaceHanger.ElementAt(i).ListSpacecraftModelProperties() + "\n");
                }
            }

            int num;
            string userChoice;

            do
            {
                Console.Clear();
                Console.WriteLine("You have 10 Spacecrafts in your hanger.");
                Console.WriteLine("0-9: See corespondence Spacecraft specs");
                Console.WriteLine("10: Launch all Spacecrafts");
                Console.WriteLine("11: Quit");
                Console.Write("Enter the number of your choice: ");
                userChoice = Console.ReadLine();

                if (!Int32.TryParse(userChoice, out num)) continue;

                if (Int32.Parse(userChoice) == 11)
                {
                    Environment.Exit(0);
                }

                if (Int32.Parse(userChoice) >=0 && Int32.Parse(userChoice) <=9)
                {
                    Console.WriteLine(" Spacecraft: " + userChoice + spaceHanger.ElementAt(Int32.Parse(userChoice)).ListSpacecraftModelProperties() + "\n");
                    Console.ReadLine();
                }

                if (Int32.Parse(userChoice) == 10 )
                {
                    launch();
                    Console.ReadLine();
                }

            } while (true);

        }

    }
}
