using System;
using System.Collections.Generic;
using System.Text;

namespace TreeProblems.Models
{
    public class Node
    {
        public Node(int data)
        {
            Data = data;
        }

        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
