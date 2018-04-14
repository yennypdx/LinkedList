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
            throw new System.NotImplementedException();
        }

        public bool Remove(T value)
        {
            throw new System.NotImplementedException();
        }

    }
}
