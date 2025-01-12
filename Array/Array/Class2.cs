using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Node
    {
        public int Data { get; set; }//wartosc
        public Node Next { get; set; }//wskaznik na nastepny
        public Node Prev { get; set; }//wskaznik na poprzedni
        public Node(int data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }

    }
}
