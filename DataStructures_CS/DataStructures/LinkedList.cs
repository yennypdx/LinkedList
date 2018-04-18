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
            if (IsEmpty)
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
            throw new System.NotImplementedException();
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
            if (!Contains(value))
                return false;
            ILinkedListNode<T> node = Find(value);
            if (node.Previous == null && node.Next == null) // only element
            {
                First = Last = null;
            }
            else if (node.Previous == null) // first element
            {
                node.Next.Previous = null;
                First = node.Next;
            }
            else if (node.Next == null) // last element
            {
                Last.Previous.Next = null;
                Last = Last.Previous;
            }
            else // middle
            {
                node.Previous.Next = node.Next;
                node.Next.Previous = node.Previous;
            }
            node = null;
            Count--;
            return true;
        }
    }
}
