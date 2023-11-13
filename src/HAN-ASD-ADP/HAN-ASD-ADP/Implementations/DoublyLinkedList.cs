using System;

namespace HAN_ASD_ADP.Implementations;

public class DoublyLinkedList<T>
{
    public int Count { get; internal set; }

    public DoublyLinkedListNode<T> Head { get; set; }

    public DoublyLinkedListNode<T> Tail { get; set; }

    public DoublyLinkedList()
    {
        Head = new(default);
        Tail = new(default);
        Head.Next = Tail;
        Tail.Previous = Head;
    }

    public void Add(T value)
    {
        var node = new DoublyLinkedListNode<T>(value);

        node.Previous = Tail.Previous;
        node.Next = Tail;
        Tail.Previous.Next = node;
        Tail.Previous = node;
        Count++;
    }

    public void Remove(T value)
    {
        var node = Find(value);
        if (node is null)
            return;

        node.Previous.Next = node.Next;
        node.Next.Previous = node.Previous;
        Count--;
    }

    public DoublyLinkedListNode<T> Get(int index)
    {
        if (index >= Count)
            throw new IndexOutOfRangeException();

        var node = Head.Next;
        for (var position = 0; position < index; position++)
        {
            node = node.Next;
        }
        return node;
    }

    public void Set(int index, T value)
    {
        if (index >= Count)
            throw new IndexOutOfRangeException();

        var node = Get(index);
        if (node is null)
            return;
        node.Value = value;
    }

    public DoublyLinkedListNode<T> Find(T value)
    {
        var node = Head.Next;
        while (node is not null && node.Next is not null)
        {
            if (node.Value.Equals(value))
                return node;
            node = node.Next;
        }
        return null;
    }
}

public class DoublyLinkedListNode<T>
{
    public T Value { get; set; }

    public DoublyLinkedListNode<T> Next { get; set; }

    public DoublyLinkedListNode<T> Previous { get; set; }

    public DoublyLinkedListNode(T value)
        => Value = value;
}