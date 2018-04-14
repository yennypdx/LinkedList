namespace DataStructures
{
    public interface ILinkedList<T>
    {
        int Count { get; }
        ILinkedListNode<T> First { get; }
        bool IsEmpty { get; }
        ILinkedListNode<T> Last { get; }

        void AddFirst(T value);
        void AddLast(T value);
        void Clear();
        bool Contains(T value);
        ILinkedListNode<T> Find(T value);
        bool Remove(T value);
        
    }
}
