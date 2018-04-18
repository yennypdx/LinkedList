namespace DataStructures
{
    public interface ILinkedListNode<T>
    {
        ILinkedList<T> List { get; set;  }
        ILinkedListNode<T> Next { get; set; }
        ILinkedListNode<T> Previous { get; set; }
        T Value { get; set; }
    }
}
