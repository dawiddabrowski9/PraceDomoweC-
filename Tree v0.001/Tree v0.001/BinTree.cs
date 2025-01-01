using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_v0._001
{
    internal class BinTree
    {
        public NodeT Root { get; set; }
        public void Insert(int value)
        {
            if (Root == null)
            {
                Root = new NodeT(value);
            }
            else
            {
                InsertR(Root, value);
            }
        }

        public void InsertR(NodeT node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new NodeT(value);
                }
                else
                {
                    InsertR(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new NodeT(value);
                }
                else
                {
                    InsertR(node.Left, value);
                }
            }
        }
        public void Delete(int value)
        {
            Root = DeleteR(Root, value);
        }

        private NodeT DeleteR(NodeT node, int value)
        {
            if (node == null)
                return null;

            if (value < node.Value)
            {
                node.Left = DeleteR(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = DeleteR(node.Right, value);
            }
            else
            {
                // Przypadek 1
                if (node.Left == null && node.Right == null)
                {
                    return null;
                }

                // Przypadek 2
                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }

                // Przypadek 3
                NodeT successor = FindMin(node.Right);
                node.Value = successor.Value;
                node.Right = DeleteR(node.Right, successor.Value);
            }

            return node;
        }
        private NodeT FindMin(NodeT node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        public List<int> InOrder()
        {
            List<int> list = new List<int>();
            InOrderInit(Root, list);
            return list;
        }


        public void InOrderInit(NodeT node, List<int> list)
        {

            if (node != null)
            {
                InOrderInit(node.Left, list);
                list.Add(node.Value);
                InOrderInit(node.Right, list);
            }
        }

        public void PreOrderInit(NodeT node, List<int> list)
        {
            if (node != null)
            {
                list.Add(node.Value);
                PreOrderInit(node.Left, list);
                PreOrderInit(node.Right, list);
            }
        }

        public void PostOrderInit(NodeT node, List<int> list)
        {
            if (node != null)
            {
                PostOrderInit(node.Left, list);
                PostOrderInit(node.Right, list);
                list.Add(node.Value);
            }
        }
        public List<int> PreOrder()
        {
            List<int> list = new List<int>();
            PreOrderInit(Root, list);
            return list;
        }

        public List<int> PostOrder()
        {
            List<int> list = new List<int>();
            PostOrderInit(Root, list);
            return list;
        }
    } 
}
