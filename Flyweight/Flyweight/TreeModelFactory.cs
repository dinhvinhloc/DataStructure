using System;
using System.Collections.Generic;

namespace Flyweight
{
    internal class TreeModelFactory
    {
        Dictionary<string, TreeModel> ModelDict = new Dictionary<string, TreeModel>();
        
        private static TreeModelFactory uniqueInstance = new TreeModelFactory();

        public static TreeModelFactory GetTreeModelFactory()
        {
            return uniqueInstance;
        }
        internal TreeModel GetTreeModel(string modeltype)
        {
            if (!ModelDict.ContainsKey(modeltype))
            {
                TreeModel model = new TreeModel();
                if (modeltype.Equals("mango"))
                {
                    model.Mesh = "Mango Tree Mesh";
                    model.Bark = "Mango Tree Bark";
                    model.Leaf = "Mango Tree Leaf";
                }
                else if (modeltype.Equals("mapple"))
                {
                    model.Mesh = "Mapple Tree Mesh";
                    model.Bark = "Mapple Tree Bark";
                    model.Leaf = "Mapple Tree Leaf";
                }
                else if(modeltype.Equals("oak"))
                {
                    model.Mesh = "Oak Tree Mesh";
                    model.Bark = "Oak Tree Bark";
                    model.Leaf = "Oak Tree Leaf";
                } else
                {
                    return null;
                }

            ModelDict[modeltype] = model;
            }


            return ModelDict[modeltype];
        }
        internal class TreeModel : ITreeModel
        {


            public string Mesh { get; set; }
            public string Bark { get; set; }
            public string Leaf { get; set; }



            public TreeModel()
            {
                Mesh = "Mango Tree Mesh";
                Bark = "Mango Tree Bark";
                Leaf = "Mango Tree Leaf";
            }

            public string GetMesh()
            {
                return Mesh;
            }

            public string GetLeaf()
            {
                return Leaf;
            }

            public string GetBark()
            {
                return Bark;
            }
        }
    }


}