using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        private List list;
        public Form1()
        {
            InitializeComponent();
            list = new List();
        }

        private void AddFirst_Click(object sender, EventArgs e)
        {
            int value = (int)NodeValue.Value;
            list.AddFirst(value);
            DisplayList();
        }

        private void AddLast_Click(object sender, EventArgs e)
        {
            
            int value = (int)NodeValue.Value;
            list.addLast(value);
            DisplayList();

        }

        private void RemoveFirst_Click(object sender, EventArgs e)
        {
            list.RemoveFirst();
            DisplayList();
        }

        private void RemoveLast_Click(object sender, EventArgs e)
        {
            list.RemoveLast();
            DisplayList();
        }

        private void NodeValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }
        public void DisplayList()
        {
             
            List<int> elements = list.DisplayForward();

            
            string listContent = string.Join(" -> ", elements);

           
            Result.Text = "Zawartość listy: " + listContent;
        }

        private void ToArray_Click(object sender, EventArgs e)
        {
            list.ToArray();
            MessageBox.Show("Konwersja Wykonana");
        }

        private void ToString_Click(object sender, EventArgs e)
        {
            list.ToString();
            MessageBox.Show("Konwersja Wykonana");
        }
    }
}
