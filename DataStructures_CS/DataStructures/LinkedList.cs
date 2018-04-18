using System;

namespace DataStructures
{
    public class LinkedList<T> : ILinkedList<T>
    {
        public int Count { get; set; }
        public ILinkedListNode<T> First { get; set; }
        public bool IsEmpty
        {
            get { return Last == null; }
        }
        public ILinkedListNode<T> Last { get; set; }

        public void AddFirst(T value)
        {
            throw new System.NotImplementedException();
        }

        public void AddLast(T value)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(T value)
        {
            throw new System.NotImplementedException();
        }

        public ILinkedListNode<T> Find(T value)
        {
           if (!this.Contains(value)) { return null; }
                
            ILinkedListNode<T> node = this.First;
            while (!node.Value.Equals(value)){ node = node.Next; }
                
            return node;
        }

        public bool Remove(T value) 
        {
            if (this.Contains(value)) {
                ILinkedListNode<T> currentNode = Find(value);

                //Node is the only item
                if (First == Last) {
                    First = null;
                    Last = null;
                }
                else {
                    //Node is the first node
                    if (currentNode.Previous == null) {
                        First = First.Next;
                        First.Previous = null;
                        First.Next = null;
                    }
                    //Node is the last node
                    if (currentNode.Next == null) {
                        Last = Last.Previous;
                        Last.Previous = null;
                        Last.Next = null;
                    }
                    //Node in the middle of two nodes
                    if (currentNode.Next == null && currentNode.Previous == null) {
                        currentNode.Previous.Next = currentNode.Next;
                        currentNode.Next.Previous = currentNode.Previous;
                        currentNode = null;
                    }
                }
                Count--;
                return true;
            }
            else {
                return false;
            }
        }
    }
}
