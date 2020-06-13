using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class ProductList
    {
        private LinkedList<Product> products;
        private double allPrice;
        private double avgPrice;

        public ProductList()
        {
            this.Products = new LinkedList<Product>();
            this.allPrice = 0;
            this.avgPrice = 0;
        }

        public double AvgPrice { get => avgPrice; set => avgPrice = value; }
        public double AllPrice { get => allPrice; set => allPrice = value; }
        public LinkedList<Product> Products { get => products; set => products = value; }

        public bool Add(Product aProduct)
        {
            if (Remove(aProduct)) {
                LinkedListNode<Product> currentNode = Products.First;
                LinkedListNode<Product> addingNode = new LinkedListNode<Product>(aProduct);
                while (currentNode != null && ComparePrice(currentNode, addingNode) < 0)
                {
                    currentNode = currentNode.Next;
                }
                if (currentNode == null)
                {
                    Products.AddLast(addingNode);
                }
                else
                {
                    Products.AddBefore(currentNode, addingNode);
                }
                UpdatePrices();
                return false;
            } else
            {
            LinkedListNode<Product> currentNode = Products.First;
            LinkedListNode<Product> item = new LinkedListNode<Product>(aProduct);
            while (currentNode != null && ComparePrice(currentNode, item) < 0)
            {
                    currentNode = currentNode.Next;
            }
            if (currentNode == null)
            {
                Products.AddLast(item);
            }
            else
            {
                Products.AddBefore(currentNode, item);
            }
            UpdatePrices();
            return true;
            }
        }

        public bool Remove(Product product)
        {
            LinkedListNode<Product> targetNode = Products.Find(product);
            if (targetNode != null)
            {
                Products.Remove(targetNode);
                UpdatePrices();
                return true;
            } else return false;
        }

        public double ComparePrice(LinkedListNode<Product> aNode, LinkedListNode<Product> bNode)
        {
            Product aP = aNode.Value;
            Product bP = bNode.Value;
            return (aP.Price - bP.Price);
        }

        public void UpdatePrices()
        {
            LinkedListNode<Product> currentNode = Products.First;
            Product tempProduct;
            allPrice = 0;
            while (currentNode != null)
            {
                tempProduct = currentNode.Value;
                allPrice = allPrice + tempProduct.Price;
                currentNode = currentNode.Next;
            }
            if (Products.Count == 0)
            {
                avgPrice = 0;
            } else avgPrice = allPrice/Products.Count;
        }
        public Product[] GetProducts()
        {
            return Products.ToArray<Product>();
        }
    }
}
