using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace GenericLinkedList.Test
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void FindEmptyListTest()
        {
            var testList = new LinkedList<int>();
            Assert.IsNull(testList.Find(5));
        }

        [TestMethod]
        public void FindValueFoundNodeReturned()
        {
            var testList = new LinkedList<int>();
            testList.AddLast(4);
            testList.AddLast(8);
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
        public void RemoveTest()
        {
            var testList = new LinkedList<int>();
            testList.AddLast(4);
            testList.AddLast(8);
            testList.AddLast(5);
            testList.Remove(8);
            Assert.IsTrue(testList.Count == 2);
            Assert.IsFalse(testList.Contains(8));
        }
    }
}
