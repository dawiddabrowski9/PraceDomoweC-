using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_v0._001
{
    public partial class Form1 : Form
    {
        private BinTree binTree;
        public Form1()
        {
            InitializeComponent();
            binTree = new BinTree();
        }
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void Add_Click(object sender, EventArgs e)
        {
            int value = (int)numericUpDown.Value;
            binTree.Insert(value);
            UpdateTreeView();
            numericUpDown.Value = 0;
        }
        public void UpdateTreeView()
        {
            treeView.Nodes.Clear();
            var rootNode = BuildTreeNode(binTree.Root);
            if (rootNode != null)
            {
                treeView.Nodes.Add(rootNode);
            }
            treeView.ExpandAll();
        }
        private TreeNode BuildTreeNode(NodeT node)
        {
            if (node == null)
            {
                return null;
            }

            
            var treeNode = new TreeNode(node.Value.ToString());

            
            if (node.Left != null)
            {
                treeNode.Nodes.Add(BuildTreeNode(node.Left));
            }

            
            if (node.Right != null)
            {
                treeNode.Nodes.Add(BuildTreeNode(node.Right));
            }

            return treeNode;
        }


        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int value = (int)numericUpDown.Value;
            binTree.Delete(value);
            UpdateTreeView();
            numericUpDown.Value = 0;
        }
    }
}
