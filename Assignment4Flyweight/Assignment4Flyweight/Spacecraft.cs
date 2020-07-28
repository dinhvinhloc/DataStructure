using System;

namespace Assignment4Flyweight
{
    internal class Spacecraft
    {
        ICraftModel craftModel;

        Coordinate coordinate = new Coordinate();
        int craftID;
        public Spacecraft(string model)
        {
            SpacecraftModelFactory factory = SpacecraftModelFactory.GetSpacecraftModelFactory();
            this.craftModel = factory.GetSpacecraftModel(model);
        }

        public int CraftID { get => craftID; set => craftID = value; }
        internal Coordinate Coordinate { get => coordinate; set => coordinate = value; }

        public string ListSpacecraftModelProperties()
        {
            return "\n Craft ID: " + CraftID +
                   "\n X: " + coordinate.X +
                   "\n Y: " + coordinate.Y +
                   "\n Mesh: " + craftModel.getMesh() +
                   "\n Texture: " + craftModel.getTexture() +
                   "\n Max Speed: " + craftModel.getMaxspeed()+ "mph" +
                   "\n Acceleration: " + craftModel.getAcceleration() +"ft/s2"+
                   "\n Damage: " + craftModel.getDamage();
        }
    }
}