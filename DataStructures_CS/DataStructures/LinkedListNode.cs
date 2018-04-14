namespace DataStructures
{
    public class LinkedListNode<T> : ILinkedListNode<T>
    {
        public ILinkedList<T> List { get; set; }
        public ILinkedListNode<T> Next { get; set; }
        public ILinkedListNode<T> Previous { get; set; }
        public T Value { get; set; }

    }
}
