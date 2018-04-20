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
            LinkedList<int> atest = new LinkedList<int>();

            Assert.IsFalse(atest.Contains(52));
        }
        [TestMethod]
        public void LinkedListContainerValueNotThereTest()
        {
            LinkedList<int> atest = new LinkedList<int>();
        
            atest.AddFirst(53);
        
            Assert.IsFalse(atest.Contains(52));
        }
    }
}
