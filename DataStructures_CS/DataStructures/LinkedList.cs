    namespace DataStructures
{
    public class LinkedList<T> : ILinkedList<T>
    {
        public int Count { get; set; }
        public ILinkedListNode<T> First { get; set; }
        public bool IsEmpty { get; }
        public ILinkedListNode<T> Last { get; set; }
        public void AddFirst(T value)
        {
            ILinkedListNode<T> newNode = new LinkedListNode<T>{Value = value};
            if (Last == null)
            {
                First = Last = newNode;
                newNode.Previous = null;
                newNode.Next = null;
                Count++;
            }

            else if (First == Last)
            {
                First.Previous = newNode;
                newNode.Previous = null;
                newNode.Next = First;
                First = newNode;
                Last = newNode.Next;
                Count++;
            }

            else
            {
                First.Previous = newNode;
                newNode.Next = First;
                newNode.Previous = null;
                First = newNode;
                Count++;
            }
        }

        public void AddLast(T value)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            ILinkedListNode<T> deleteNode = First;
            while (deleteNode != null)
            {
                ILinkedListNode<T> nextNode = deleteNode.Next;
                deleteNode = null;
                deleteNode = nextNode;
                Count--;
            }
            First = Last = null;
        }

        public bool Contains(T value)
        {
            throw new System.NotImplementedException();
        }

        public ILinkedListNode<T> Find(T value)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(T value)
        {
            throw new System.NotImplementedException();
        }

    }
}
