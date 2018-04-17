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
           if (First == null)
            {
                First = new LinkedListNode<T> { Value = value };
                Last = new LinkedListNode<T> { Value = value };
            }
        }
        public void AddLast(T value)
        {
            if (Last == null)
            {
                Last = new LinkedListNode<T> { Value = value };
                First = new LinkedListNode<T> { Value = value };
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
            throw new System.NotImplementedException();
        }

    }
}
