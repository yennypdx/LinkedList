using System;
using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericLinkedList.Test
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void TestRemovingFirstElementOnTheList()
        {
            LinkedList<int> testList = new LinkedList<int>();
            testList.AddLast(4);
            testList.AddLast(3);
            testList.AddLast(2);
            testList.AddLast(1);
            
            testList.Remove(4);
            Assert.IsTrue(testList.Count == 3);
            Assert.IsTrue(testList.First.Value == 3);
        }

        [TestMethod]
        public void TestRemovingLastElementOnTheList()
        {
            LinkedList<int> testList = new LinkedList<int>();
            testList.AddLast(4);
            testList.AddLast(3);
            testList.AddLast(2);
            testList.AddLast(1);

            testList.Remove(1);
            Assert.IsTrue(testList.Count == 3);
            Assert.IsTrue(testList.Last.Value == 2);
        }

        //[TestMethod]
        //public void TestRemovingElementInBetweenElementsOnTheList()
        //{
        //    throw new System.NotImplementedException();
        //}

        //[TestMethod]
        //public void TestRemovingElementNotInTheList()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
