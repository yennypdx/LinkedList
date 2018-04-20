using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void FindStringFoundNodeReturnedLast()
        {
            var testList = new LinkedList<string>();
            testList.AddLast("This ");
            testList.AddLast("is a ");
            testList.AddLast("test.");
            Assert.AreEqual(testList.Last, testList.Find("test."));
        }

        [TestMethod]
        public void FindStringFoundNodeReturnedFirst()
        {
            var testList = new LinkedList<string>();
            testList.AddLast("This ");
            testList.AddLast("is a ");
            testList.AddLast("test.");
            Assert.AreEqual(testList.First, testList.Find("This "));
        }

        [TestMethod]
        public void FindStringFoundNodeReturnedMiddle()
        {
            var testList = new LinkedList<string>();
            testList.AddLast("This ");
            testList.AddLast("is a ");
            testList.AddLast("test.");
            ILinkedListNode<string> middleNode = testList.Find("is a ");
            Assert.AreEqual(middleNode.Value, "is a ");
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
            Assert.AreEqual(0, emptyList.Count);
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

        [TestMethod]
        public void TestRemovingFirstElementOnTheList()
        {
            ILinkedList<int> testList = new LinkedList<int>();
            testList.AddLast(4);
            testList.AddLast(3);
            testList.AddLast(2);
            testList.AddLast(1);
            testList.Remove(4);
            Assert.IsTrue(testList.First.Value == 3);
        }

        [TestMethod]
        public void TestRemovingFirstElementOnTheListStrings()
        {
            ILinkedList<string> testList = new LinkedList<string>();
            testList.AddLast("shant");
            testList.AddLast("yenny");
            testList.AddLast("nick");
            testList.AddLast("rachel");
            testList.Remove("shant");
            Assert.IsTrue(testList.First.Value == "yenny");
        }

        [TestMethod]
        public void TestRemovingLastElementOnTheList()
        {
            ILinkedList<int> testList = new LinkedList<int>();
            testList.AddLast(4);
            testList.AddLast(3);
            testList.AddLast(2);
            testList.AddLast(1);
            testList.Remove(1);
            Assert.IsTrue(testList.Last.Value == 2);
        }

        [TestMethod]
        public void TestRemovingLastElementOnTheListStrings()
        {
            ILinkedList<string> testList = new LinkedList<string>();
            testList.AddLast("shant");
            testList.AddLast("yenny");
            testList.AddLast("nick");
            testList.AddLast("rachel");
            testList.Remove("rachel");
            Assert.IsTrue(testList.Last.Value == "nick");
        }

        [TestMethod]
        public void TestRemovingElementInBetweenElementsOnTheList()
        {
            ILinkedList<int> testList = new LinkedList<int>();
            testList.AddLast(4);
            testList.AddLast(3);
            testList.AddLast(2);
            testList.AddLast(1);
            testList.Remove(2);
            Assert.IsTrue(testList.Count == 3);
        }

        [TestMethod]
        public void TestRemovingElementInBetweenElementsOnTheListStrings()
        {
            ILinkedList<string> testList = new LinkedList<string>();
            testList.AddLast("shant");
            testList.AddLast("yenny");
            testList.AddLast("nick");
            testList.AddLast("rachel");
            testList.Remove("nick");
            Assert.IsFalse(testList.Contains("nick"));
        }

        [TestMethod]
        public void TestRemovingElementNotInTheList()
        {
            ILinkedList<int> testList = new LinkedList<int>();
            testList.AddLast(4);
            testList.AddLast(3);
            testList.AddLast(2);
            testList.AddLast(1);
            testList.Remove(5);
            Assert.IsFalse(testList.Contains(5));
        }

        [TestMethod]
        public void TestRemovingElementNotInTheListString()
        {
            ILinkedList<string> testList = new LinkedList<string>();
            testList.AddLast("shant");
            testList.AddLast("yenny");
            testList.AddLast("nick");
            testList.AddLast("rachel");
            testList.Remove("john");
            Assert.IsFalse(testList.Contains("john"));
        }

        public void LinkedListContainsFirstTest()
        {
            LinkedList<int> atest = new LinkedList<int>();
            atest.AddFirst(52);
            Assert.IsTrue(atest.Contains(52));
        }

        public void LinkedListContainsFirstTestString()
        {
            LinkedList<string> atest = new LinkedList<string>();
            atest.AddFirst("shant");
            Assert.IsTrue(atest.Contains("shant"));
        }

        [TestMethod]
        public void LinkedListContainsLastTest()
        {
            LinkedList<int> atest = new LinkedList<int>();
            atest.AddLast(52);
            Assert.IsTrue(atest.Contains(52));
        }

        [TestMethod]
        public void LinkedListContainsLastTestString()
        {
            LinkedList<string> atest = new LinkedList<string>();
            atest.AddLast("shant");
            Assert.IsTrue(atest.Contains("shant"));
        }

        [TestMethod]
        public void LinkedListContainsTest()
        {
            LinkedList<int> atest = new LinkedList<int>();
            atest.AddFirst(52);
            atest.AddFirst(53);
            atest.AddFirst(54);
            Assert.IsTrue(atest.Contains(53));
        }

        [TestMethod]
        public void LinkedListContainsTestString()
        {
            LinkedList<string> atest = new LinkedList<string>();
            atest.AddFirst("shant");
            atest.AddFirst("ahuja");
            atest.AddFirst("singh");
            Assert.IsTrue(atest.Contains("ahuja"));
        }

        [TestMethod]
        public void LinkedListContainerEmptyTest()
        {
            var testList = new LinkedList<string>();
            Assert.IsFalse(testList.Contains("something"));
        }

        [TestMethod]
        public void LinkedListContainerValueNotThereTest()
        {
            var testList = new LinkedList<string>();
            testList.AddFirst("something");
            Assert.IsFalse(testList.Contains("nothing"));
        }
    };
}
