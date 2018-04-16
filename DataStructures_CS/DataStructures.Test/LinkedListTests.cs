using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace GenericLinkedList.Test
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void LinkedListContainsFirstTest()
        {
            LinkedList<int> atest = new LinkedList<int>();

            atest.AddFirst(52);

            Assert.IsTrue(atest.Contains(52));
        }
        [TestMethod]
        public void LinkedListContainsLastTest()
        {
            LinkedList<int> atest = new LinkedList<int>();

            atest.AddLast(52);

            Assert.IsTrue(atest.Contains(52));
        }
        [TestMethod]
        public void LinkedListContainsTest()
        {
            LinkedList<int> atest = new LinkedList<int>();

            atest.AddFirst(52);
            atest.AddFirst(53);
            atest.AddFirst(54);
            //Needs AddFirst Fully Implemented
            Assert.IsTrue(atest.Contains(53));
        }
        [TestMethod]
        public void LinkedListContainerEmptyTest()
        {
            //try
            //{
            //    LinkedList<int> atest = new LinkedList<int>();

            //    Assert.IsTrue(atest.Contains(52));
            //}
            //catch() Unsure what to catch
            //{

            //}
        }
        [TestMethod]
        public void LinkedListContainerValueNotThereTest()
        {
            //try
            //{
            //    LinkedList<int> atest = new LinkedList<int>();

            //    atest.AddFirst(53);

            //    Assert.IsTrue(atest.Contains(52));
            //}
            //catch() Unsure what to catch
            //{

            //}
        }
    }
}
