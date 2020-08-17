using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TreeProblems.Models;
using TreeProblems.Traversals.VerticalOrderTraversal;
using System.Linq;

namespace TreeProblems.Tests.Traversals.VerticalOrderTraversal
{
    [TestClass]
    public class VerticalOrderTraversalV1Tests
    {
        [TestMethod]
        public void Given_BinaryTree_When_VerticalTraversal_Then_ShouldReturnNodesInVerticalOrder()
        {
            //Given
            Node root = new Node(1);

            root.Left = new Node(2);
            root.Right = new Node(3);

            root.Left.Left = new Node(4);
            root.Left.Right = new Node(5);

            root.Left.Right.Left = new Node(6);
            root.Left.Right.Right = new Node(7);

            var problem = new VerticalOrderTraversalV1();

            var expectedResult = new Dictionary<int, IList<int>>();
            expectedResult.Add(0, new List<int> { 1, 5 });
            expectedResult.Add(-1, new List<int> { 2, 6});
            expectedResult.Add(1, new List<int> { 3, 7 });
            expectedResult.Add(-2, new List<int> { 4 });

            //When
            var actualResult = problem.Traverse(root);

            //Then
            foreach(var expectedItem in expectedResult)
            {
                var actualItem = actualResult[expectedItem.Key];
                var expectedArray = expectedItem.Value.ToArray();
                var actualArray = actualItem.ToArray();
                Array.Sort(actualArray);
                Array.Sort(expectedArray);

                Assert.AreEqual(actualArray.Length, expectedArray.Length);
                for (var i = 0; i < actualArray.Length; i++)
                {
                    Assert.AreEqual(expectedArray[i], actualArray[i]);
                }
            }
        }
    }
}
