using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_v0._001
{
    internal class NodeT
    {
        public int Value { get; set; }
        public NodeT Left { get; set; }
        public NodeT Right { get; set; }
        public NodeT(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
