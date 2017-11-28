using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int Data;
        public Node Right, Left;

        public Node(int data)
        {
            Data = data;
            Right = null;
            Left = null;
        }

        public void AddNode(int data)
        {
            if (data < Data && Left == null)
            {
                Left = new Node(data);
            }
            else if (data >= Data && Right == null)
            {
                Right = new Node(data);
            }
            else if (data < Data && Left != null)
            {
                Left.AddNode(data);
            }
            else if (data >= Data && Right != null)
            {
                Right.AddNode(data);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node firstNode = new Node(10);
            
            firstNode.AddNode(8);
            firstNode.AddNode(15);
            firstNode.AddNode(5);
            firstNode.AddNode(9);
            firstNode.AddNode(12);
            firstNode.AddNode(18);
        }
    }
}
