using System;
using System.Collections.Generic;

namespace Assignment4Flyweight
{
    internal class SpacecraftModelFactory
    {
        Dictionary<string, SpacecraftModel> SpaceCraftModelDict = new Dictionary<string, SpacecraftModel>();

        private static SpacecraftModelFactory uniqueInstance = new SpacecraftModelFactory();

        public static SpacecraftModelFactory GetSpacecraftModelFactory()
        {
            return uniqueInstance;
        }

        internal SpacecraftModel GetSpacecraftModel(string modeltype)
        {
            if (!SpaceCraftModelDict.ContainsKey(modeltype))
            {
                SpacecraftModel model = new SpacecraftModel();
                if (modeltype.Equals("NukeMayhem"))
                {
                    model.ModelMesh = "Adamantium";
                    model.ModelTexture = "Hammered Black Metal";
                    model.MaxSpeed = 1200;
                    model.Acceleration = 13000;
                    model.Damage = 10000;

                }
                else if (modeltype.Equals("CoreDriller"))
                {
                    model.ModelMesh = "Amethyst";
                    model.ModelTexture = "Purple Gemstone";
                    model.MaxSpeed = 500;
                    model.Acceleration = 1000;
                    model.Damage = 50000;

                }
                else if (modeltype.Equals("SwiftMaple"))
                {
                    model.ModelMesh = "Carbon Fiber";
                    model.ModelTexture = "Black with Hexagonal";
                    model.MaxSpeed = 1800;
                    model.Acceleration = 20000;
                    model.Damage = 1000;

                }
                else
                {
                    return null;
                }

                SpaceCraftModelDict[modeltype] = model;
            }


            return SpaceCraftModelDict[modeltype];
        }

        internal class SpacecraftModel : ICraftModel
        {


            public string ModelMesh { get; set; }
            public string ModelTexture { get; set; }
            public int MaxSpeed { get; set; }
            public float Acceleration { get; set; }
            public float Damage { get; set; }

            public SpacecraftModel()
            {
                ModelMesh = "";
                ModelTexture = "";
                MaxSpeed = 0;
                Acceleration = 0;
                Damage = 0;
            }

            public string getMesh()
            {
                return ModelMesh;
            }

            public string getTexture()
            {
                return ModelTexture;
            }

            public int getMaxspeed()
            {
                return MaxSpeed;
            }

            public float getAcceleration()
            {
                return Acceleration;
            }

            public float getDamage()
            {
                return Damage;
            }
        }
    }
}