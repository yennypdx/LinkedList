using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericLinkedList.Test
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void AddFirstTestEmptyList()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddFirst("shant");
            Assert.AreEqual("shant", emptyList.First.Value);
        }

        [TestMethod]
        public void AddFirstTestEmptyListCheckCount()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddFirst("shant");
            Assert.AreEqual(1, emptyList.Count);
        }

        [TestMethod]
        public void AddFirstTestOneNodeListCheckFirst()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddFirst("shant");
            emptyList.AddFirst("ahuja");
            Assert.AreEqual("ahuja", emptyList.First.Value);
        }

        [TestMethod]
        public void AddFirstTestOneNodeListCheckCount()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddFirst("shant");
            emptyList.AddFirst("ahuja");
            Assert.AreEqual(2, emptyList.Count);
        }

        [TestMethod]
        public void AddFirstTestOneNodeListCheckLast()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddFirst("shant");
            emptyList.AddFirst("ahuja");
            Assert.AreEqual("shant", emptyList.Last.Value);
        }

        [TestMethod]
        public void AddFirstTestTwoOrMoreNodesListCheckFirst()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddFirst("shant");
            emptyList.AddFirst("ahuja");
            emptyList.AddFirst("singh");
            Assert.AreEqual("singh", emptyList.First.Value);
        }

        [TestMethod]
        public void AddFirstTestTwoOrMoreNodesListCheckCount()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddFirst("shant");
            emptyList.AddFirst("ahuja");
            emptyList.AddFirst("singh");
            Assert.AreEqual(3, emptyList.Count);
        }

        [TestMethod]
        public void AddFirstTestTwoOrMoreNodesListCheckLast()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddFirst("shant");
            emptyList.AddFirst("ahuja");
            emptyList.AddFirst("singh");
            Assert.AreEqual("shant", emptyList.Last.Value);
        }

        [TestMethod]
        public void ClearTestEmptyList()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.Clear();
            Assert.IsNull(emptyList.First);
        }

        [TestMethod]
        public void ClearTestEmptyListCheckCount()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.Clear();
            Assert.AreEqual(0,emptyList.Count);
        }

        [TestMethod]
        public void ClearTestNodesInList()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddFirst("shant");
            emptyList.AddFirst("ahuja");
            emptyList.AddFirst("singh");
            emptyList.Clear();
            Assert.IsNull(emptyList.First);
        }

        [TestMethod]
        public void ClearTestNodesInListCheckCount()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddFirst("shant");
            emptyList.AddFirst("ahuja");
            emptyList.AddFirst("singh");
            emptyList.Clear();
            Assert.AreEqual(0, emptyList.Count);
        }
    }
}
