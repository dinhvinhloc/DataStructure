namespace Flyweight
{
    internal class Tree
    {
        //string mesh = "Mango Tree Mesh";
        //string bark = "Mango Tree Bark";
        //string leaf = "Mango Tree Leaf";

        ITreeModel model;

        public Tree(string model)
        {
            TreeModelFactory factory = TreeModelFactory.GetTreeModelFactory();
            this.model = factory.GetTreeModel(model);
        }

        public string param { get; set; }
        public string position { get; set; }

        public string ListTreeModelProperties()
        {
            return model.GetMesh() +", " + model.GetLeaf() + ", " + model.GetBark();
        }


    }
}