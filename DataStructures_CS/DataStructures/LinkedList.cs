    namespace DataStructures
{
    public class LinkedList<T> : ILinkedList<T>
    {
        public int Count { get; set; }
        public ILinkedListNode<T> First { get; set; }
        public bool IsEmpty { get { return Last == null; }}
        public ILinkedListNode<T> Last { get; set; }

        public void AddFirst(T value)              
        {
            if (IsEmpty)
            {
                First = new LinkedListNode<T> { Value = value, Previous = null, Next = null };
                Last = First;
                Count++;
            }
            else
            {
                var newNode = new LinkedListNode<T> { Value = value, Previous = null, Next = First };
                First.Previous = newNode;
                First = newNode;
                Count++;
            }
        }

        public void AddLast(T value)
        {
            if(IsEmpty)
            {
                Last = new LinkedListNode<T> { Value = value, Previous = null, Next = null };
                First = Last;
                Count++;
            }
            else
            {
                var newNode = new LinkedListNode<T> { Value = value, Previous = Last, Next = null };
                Last.Next = newNode;
                Last = newNode;
                Count++;
            }
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
            if(IsEmpty == false)
            {
                if(First.Value.Equals(value))
                {
                    return true;
                }
                else if(Last.Value.Equals(value))
                {
                    return true;
                }
                else
                {
                    ILinkedListNode<T> temp = First;
                    while(!temp.Value.Equals(value) && temp != Last)
                    {
                        temp = temp.Next;
                    }
                    if(temp == Last)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public ILinkedListNode<T> Find(T value)
        {
            if(!this.Contains(value))
                return null;
            ILinkedListNode<T> node = this.First;
            while(!node.Value.Equals(value))
                node = node.Next;
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
