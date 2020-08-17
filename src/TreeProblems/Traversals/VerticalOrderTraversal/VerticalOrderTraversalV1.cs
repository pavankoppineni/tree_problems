using System;
using System.Collections.Generic;
using System.Text;
using TreeProblems.Models;

namespace TreeProblems.Traversals.VerticalOrderTraversal
{
    /// <summary>
    /// https://www.geeksforgeeks.org/print-binary-tree-vertical-order/
    /// </summary>
    public class VerticalOrderTraversalV1
    {
        public IDictionary<int, IList<int>> Traverse(Node node)
        {
            var verticalDistanceTable = new Dictionary<int, IList<int>>();
            FindDistance(node, 0, verticalDistanceTable);
            return verticalDistanceTable;
        }

        private void FindDistance(Node node, int horizontalDistance, IDictionary<int, IList<int>> verticalDistanceTable)
        {
            if (node == null)
            {
                return;
            }

            if (verticalDistanceTable.ContainsKey(horizontalDistance))
            {
                verticalDistanceTable[horizontalDistance].Add(node.Data);
            }
            else
            {
                var nodeList = new List<int>();
                nodeList.Add(node.Data);
                verticalDistanceTable.Add(horizontalDistance, nodeList);
            }

            FindDistance(node.Left, horizontalDistance - 1, verticalDistanceTable);
            FindDistance(node.Right, horizontalDistance + 1, verticalDistanceTable);
        }
    }
}
