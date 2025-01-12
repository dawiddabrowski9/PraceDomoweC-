using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    internal class List
    {
        public Node head;
        public Node tail;
        public List() 
        { 
            head = null;
            tail = null;
        }

        public void addLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail; 
                tail = newNode;
            }
        }
        public List<int> DisplayForward()
        {
            List<int> elements = new List<int>();
            Node current = head;
            while (current != null)
            {
                elements.Add(current.Data);
                current = current.Next;
            }
            return elements;
        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);

            if (head == null) 
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head; 
                head.Prev = newNode;
                head = newNode; 
            }
        }
        public void RemoveFirst()
        {
            if (head == null)
            { 
                return;
            }

            if (head.Next == null)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.Next;
                head.Prev = null;
            }
        }
        public void RemoveLast()
        {
            if (tail == null)
            {
                return;
            }

            if (tail.Prev == null)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.Prev;
                tail.Next = null;
            }
        }
        public int[] ToArray()
        {
            List<int> elements = new List<int>();
            Node current = head;
            if (head == null)
            {
                MessageBox.Show("Lista jest pusta!");
            }
            while (current != null)
            {
                elements.Add(current.Data);
                current = current.Next;
            }

            return elements.ToArray();
        }
        public override string ToString()
        {
            if (head == null)
            {
                MessageBox.Show("Lista jest pusta!");
            }

            Node current = head;
            List<string> elements = new List<string>();

            while (current != null)
            {
                elements.Add(current.Data.ToString());
                current = current.Next;
            }

            return string.Join(" -> ", elements);
        }

    }
}
