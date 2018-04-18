using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace GenericLinkedList.Test
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void FindContainsReturnsFalseTest()
        {
            var testList = new LinkedList<int>();
            Assert.IsNull(testList.Find(5));
        }

        [TestMethod]
        public void FindValueFoundNodeReturned()
        {
            var testList = new LinkedList<int>();
            testList.AddLast(5);
            Assert.AreEqual(testList.Last, testList.Find(5));
        }

        [TestMethod]
        public void FindStringFoundNodeReturned()
        {
            var testList = new LinkedList<string>();
            testList.AddLast("This ");
            testList.AddLast("is a ");
            testList.AddLast("test.");
            Assert.AreEqual(testList.Last, testList.Find("test."));
        }

        [TestMethod]
        public void FindValueNotFound()
        {
            var testList = new LinkedList<int>();
            testList.AddLast(4);
            testList.AddLast(8);
            testList.AddLast(5);
            Assert.IsNull(testList.Find(9));
        }

        [TestMethod]
        public void FindStringNotFound()
        {
            var testList = new LinkedList<string>();
            testList.AddLast("This ");
            testList.AddLast("is a ");
            testList.AddLast("test.");
            Assert.IsNull(testList.Find("not there"));
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
        public void AddLastTestEmptyList()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddLast("shant");
            Assert.AreEqual("shant", emptyList.Last.Value);
        }

        [TestMethod]
        public void AddLastTestEmptyListCheckCount()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddLast("shant");
            Assert.AreEqual(1, emptyList.Count);
        }

        [TestMethod]
        public void AddLastTestOneNodeListCheckFirst()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddLast("shant");
            emptyList.AddLast("ahuja");
            Assert.AreEqual("shant", emptyList.First.Value);
        }

        [TestMethod]
        public void AddLastTestOneNodeListCheckCount()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddLast("shant");
            emptyList.AddLast("ahuja");
            Assert.AreEqual(2, emptyList.Count);
        }

        [TestMethod]
        public void AddLastTestOneNodeListCheckLast()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddLast("shant");
            emptyList.AddLast("ahuja");
            Assert.AreEqual("ahuja", emptyList.Last.Value);
        }

        [TestMethod]
        public void AddLastTestTwoOrMoreNodesListCheckFirst()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddLast("shant");
            emptyList.AddLast("ahuja");
            emptyList.AddLast("singh");
            Assert.AreEqual("shant", emptyList.First.Value);
        }

        [TestMethod]
        public void AddLastTestTwoOrMoreNodesListCheckCount()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddLast("shant");
            emptyList.AddLast("ahuja");
            emptyList.AddLast("singh");
            Assert.AreEqual(3, emptyList.Count);
        }

        [TestMethod]
        public void AddLastTestTwoOrMoreNodesListCheckLast()
        {
            ILinkedList<string> emptyList = new LinkedList<string>();
            emptyList.AddLast("shant");
            emptyList.AddLast("ahuja");
            emptyList.AddLast("singh");
            Assert.AreEqual("singh", emptyList.Last.Value);
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
