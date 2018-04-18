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
            ILinkedListNode<T> newNode = new LinkedListNode<T> { Value = value };
            if (Last == null)
            {
                First = Last = newNode;
                newNode.Previous = null;
                newNode.Next = null;
                Count++;
            }

            else if (First == Last)
            {
                newNode.Previous = Last;
                newNode.Next = null;
                Last.Next = newNode;
                Last = newNode;
                Count++;
            }

            else
            {
                Last.Next = newNode;
                newNode.Previous = Last;
                newNode.Next = null;
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
            throw new System.NotImplementedException();
        }

    }
}
